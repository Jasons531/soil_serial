using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soil_Serial
{
    public partial class Form1 : Form
    {
        public SerialPort SerialDevice = new SerialPort();
        private TempHumidity TempHumiditys = new TempHumidity();
        private Rs485 Rs485s = new Rs485();
        private SoilEC SoilEC = new SoilEC();
        private bool FirstSysTime = true;
        private DateTime dt1;
        private DateTime dt2;
        private bool SoilECMode = false;
        private int collectime = 0;
        private string buffer = null;

        internal TempHumidity TempHumiditys1 { get => TempHumiditys; set => TempHumiditys = value; }

        public delegate void UpdateForm_dl();//声明委托

        //使用多线程计时器
        private System.Timers.Timer timer = new System.Timers.Timer();

        public Form1()
        {
            InitializeComponent();
            InitSerialConfig();
            TempHumiditys.InitWidget(SerialDevice, SoilTempLabel, textSoilTemp, StempCalibra, StempClear, HumdataLabel,
                                    textSoilHumid, SHumidCalibra, SHumidClear, SoilCheck, richTextBox1);
            richTextBox1.Text = "鼠标左键双击，清除显示";            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 初始化串口
        /// </summary>
        private void InitSerialConfig()
        {
            string[] PortNames = SerialPort.GetPortNames();    //获取本机串口名称，存入PortNames数组中 
            foreach (string s in PortNames)   //添加串口
            {
                SerialId.Items.Add(s);          //获取有多少个COM口，添加到控件里
            }
            if (PortNames.Count() > 0)
            {
                SerialId.SelectedIndex = 0;
            }

            ///设置标定模式；默认土壤温湿度
            SetModebox.Items.Add("土壤温湿度");
            SetModebox.Items.Add("土壤电导率");
            SetModebox.SelectedIndex = 0;

            SerialDevice.DataReceived += new SerialDataReceivedEventHandler(SerialDevice_DataReceived); //订阅委托 
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            timer.Interval = 10;
        }       

        /// <summary>
        /// 获取土壤EC传感器数据命令
        /// </summary>
         private void GetSoilTempEC()
        {
            Byte[] SendCmds = new Byte[8] { 0xf8, 0x03, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00 };

            Rs485s.GetCrc(SendCmds, 6);
            SerialDevice.Write(SendCmds, 0, 8);
            richTextBox1.AppendText(Rs485s.ByteToString(SendCmds));
        }

        //public void InitThread()
        //{
        //    Thread thr = new Thread(new ThreadStart(RichTextBoxProcess));//创建线程 
        //    thr.Start();
        //    thr.IsBackground = true; ///将线程转为后台线程
        //}

        //private void RichTextBoxProcess()
        //{
        //    this.BeginInvoke(new UpdateForm_dl(UpdateForm)); ///调用委托
        //}

        //public void UpdateForm()
        //{
        //    if(buffer!=null)
        //    {
        //        richTextBox1.AppendText(buffer + "\r\n");
        //        FileShare(buffer + "\r\n");

        //        buffer = null;
        //    }
        //}

        /// <summary>
        /// 打开串口控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenSerial_Click(object sender, EventArgs e)
        {
            if (OpenSerial.Text == "打开串口")
            {
                if (!SerialDevice.IsOpen)
                {
                    try
                    {
                        if (SerialDevice.IsOpen)
                        {
                            SerialDevice.Close();
                        }
                        SerialDevice.PortName = SerialId.SelectedItem.ToString();//设置串口号,获取外部选择串口;
                        SerialDevice.BaudRate = 9600;
                        //一个停止位
                        SerialDevice.StopBits = System.IO.Ports.StopBits.One;
                        SerialDevice.DataBits = 8;
                        //无奇偶校验位
                        SerialDevice.Parity = System.IO.Ports.Parity.None;

                        SerialDevice.RtsEnable = false;
                        SerialDevice.DtrEnable = false;
                        SerialDevice.ReadTimeout = 1;
                        SerialDevice.WriteTimeout = 10;
                        SerialDevice.Open();
                        FirstSysTime = true;

                        if (SetModebox.Text == "土壤温湿度")
                        {
                            SoilECMode = false;                       
                        }
                        else if (SetModebox.Text == "土壤电导率")
                        {
                            SoilECMode = true;                          
                        }

                        timer.Start();
                        
                        if (CollectTime.Text == "采集时间(最好>5s)")
                        {
                            CollectTime.Text = "5";                            
                        }
                        collectime = Convert.ToInt32(CollectTime.Text);

                        TempHumiditys.GetSoilTempHumidity();
                    }
                    catch (System.Exception)
                    {
                        //MessageBox.Show("Error:" + ex.Message, "Error");
                        MessageBox.Show("打开串口失败");
                        SerialId.Items.Clear();
                        OpenSerial.Text = "打开串口";
                        return;
                    }
                }
                OpenSerial.Text = "关闭串口";              
            }
            else
            {
                OpenSerial.Text = "打开串口";
                SerialDevice.Close();
                timer.Stop();
            }
        }

         /// <summary>
        /// 文件保存
        /// </summary>
        /// <param name="text"></param>
        public void FileShare(string text)
        {          
            if (!File.Exists(".\\" + SetModebox.Text + "-" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt"))
            {
                FileStream fs1 = new FileStream(".\\" + SetModebox.Text + "-" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", FileMode.Create, FileAccess.Write);//创建写入文件                
                fs1.Close();
                
                StreamWriter sw = new StreamWriter(".\\" + SetModebox.Text + "-" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", true);           
                sw.Write(text);//开始写入值
                sw.Close();
            }
            else
            {
                FileStream fs = new FileStream(".\\" + SetModebox.Text + "-" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", FileMode.Open, FileAccess.Write);
                fs.Close();
               
                StreamWriter sr = new StreamWriter(".\\" + SetModebox.Text + "-" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt", true);
                sr.Write(text);//开始写入值
                sr.Close();             
            }
        }

        /// <summary>
        /// 定时查询传感器数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (!SoilECMode)
            {
                TempHumiditys.GetSoilTempHumidity();
            }
            else
            {
                //获取土壤EC传感器数据
                //    GetSoilTempEC();
            }
            timer.Interval = collectime * 1000 + 50;
        }

        /// <summary>
        /// 串口接收委托事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SerialDevice_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int SoilTemp = 0;
            int SoilHumidity = 0;
            int SoilEC = 0;

            if (SerialDevice.IsOpen)
            {
                this.Invoke((EventHandler)(delegate
                {
                Byte[] ReceiveData = new Byte[SerialDevice.BytesToRead]; ///接收到ARM数据格式为char - 16进制模式
                SerialDevice.Read(ReceiveData, 0, ReceiveData.Length);

                if (ReceiveData[0] == 0xf8 || ReceiveData[0] == 0xf9)
                {
                    if (FirstSysTime)
                    {
                        dt1 = DateTime.Parse(DateTime.Now.ToString());
                        richTextBox1.AppendText(DateTime.Now.ToString("【HH:mm:ss】")); ///【HH:mm:ss:fff】
                        FileShare(DateTime.Now.ToString("【HH:mm:ss】"));
                        FirstSysTime = false;
                    }

                    dt2 = DateTime.Parse(DateTime.Now.ToLocalTime().ToString());
                    //利用TimeSpan计算时间差 
                    TimeSpan ts1 = new TimeSpan(dt1.Ticks);
                    TimeSpan ts2 = new TimeSpan(dt2.Ticks);
                    TimeSpan ts3 = ts2.Subtract(ts1); //ts2-ts1
                    int sumMilliSeconds = int.Parse(ts3.TotalMilliseconds.ToString()); //得到相差毫秒数

                    if (sumMilliSeconds >= Convert.ToInt32(CollectTime.Text) * 1000) //判断是否大于CollectTime.Text
                    {
                        dt1 = DateTime.Parse(DateTime.Now.ToString());
                        richTextBox1.AppendText(DateTime.Now.ToString("【HH:mm:ss】"));
                        FileShare(DateTime.Now.ToString("【HH:mm:ss】"));
                    }
                    //richTextBox1.AppendText(Rs485s.ByteToString(ReceiveData));
                    if (SoilECMode)
                    {
                        if (ReceiveData[2] == 0x04)
                        {
                            SoilTemp = (ReceiveData[3] & 0xff) << 8 | ReceiveData[4] & 0xff;
                            SoilEC = (ReceiveData[5] & 0xff) << 8 | ReceiveData[6] & 0xff;
                            buffer = "土壤电导率: " + "温度: " + (float)(SoilTemp / 10.0) + "℃" + "   " + "EC: " + (float)(SoilEC / 1000.0) + "ds/cm" + "\r\n";
                            //richTextBox1.AppendText("土壤电导率: " + "温度: " + (float)(SoilTemp / 10.0) + "℃" + "   " + "EC: " + (float)(SoilEC / 1000.0) + "ds/cm" + "\r\n");
                            //FileShare("土壤电导率: " + "温度: " + (float)SoilTemp / 10 + "℃" + "   " + "EC: " + (float)SoilEC / 1000 + "ds/cm" + "\r\n");
                        }
                        else
                        {
                            switch (ReceiveData[3])
                            {
                                case 0x01:
                                case 0x02:
                                    buffer = "土壤温度标定完成";
                                    break;
                                case 0x03:
                                    buffer = "土壤温度清除标定";
                                    break;
                                case 0x05:
                                case 0x06:
                                    buffer = "土壤EC_L标定完成";
                                    break;
                                case 0x07:
                                case 0x08:
                                    buffer = "土壤EC_M标定完成";
                                    break;
                                case 0x09:
                                case 0x0A:
                                    buffer = "土壤EC_H标定完成";
                                    break;
                                case 0x0B:
                                    buffer = "土壤EC清除三点标定完成";
                                    break;
                                case 0x0C:
                                    buffer = "查询土壤温度、EC";
                                    break;
                                default:
                                    break;
                            }
                            richTextBox1.AppendText(buffer + "\r\n");
                            FileShare(buffer + "\r\n");
                        }
                    }
                    else
                    {
                        if (ReceiveData[2] == 0x04)
                        {
                            SoilTemp = (ReceiveData[3] & 0xff) << 8 | ReceiveData[4] & 0xff;
                            SoilHumidity = (ReceiveData[5] & 0xff) << 8 | ReceiveData[6] & 0xff;

                            SoilTempLabel.Text = ((float)SoilTemp / 10).ToString();
                            HumdataLabel.Text = (((ReceiveData[7] & 0xff) << 8 | ReceiveData[8] & 0xff)).ToString();
                            HumidityLabel.Text = ((float)SoilHumidity / 10).ToString();
                            //buffer = "土壤温湿度: " + "温度: " + (float)SoilTemp / 10 + "℃" + "     " + "湿度: " + (float)SoilHumidity / 10 + "％";
                            richTextBox1.AppendText("土壤温湿度: " + "温度: " + (float)SoilTemp / 10 + "℃" + "     " + "湿度: " + (float)SoilHumidity / 10 + "％" + "\r\n");
                            FileShare("土壤温湿度: " + "温度: " + (float)SoilTemp / 10 + "℃" + "   " + "湿度: " + (float)SoilHumidity / 10 + "％" + "\r\n");
                        }
                        else
                        {
                            switch (ReceiveData[3])
                            {
                                case 0x01:
                                case 0x02:
                                    buffer = "土壤温度标定完成";
                                    break;
                                case 0x03:
                                    buffer = "土壤温度清除标定";
                                    break;
                                case 0x05:
                                case 0x06:
                                    buffer = "土壤湿度标定完成";
                                    break;
                                case 0x07:
                                    buffer = "土壤湿度清除标定";
                                    break;
                                case 0x08:
                                    float datatemp = 0;
                                    datatemp = (float)(((ReceiveData[4] & 0xff) << 8 | ReceiveData[5] & 0xff)) / 10;
                                    if(datatemp>0)
                                    {
                                       CalibrasoiltempLabel.Text = datatemp.ToString();
                                    }
                                    else
                                    {
                                       CalibrasoiltempLabel.Text = (datatemp*-1).ToString();
                                    }
                                    datatemp = ((ReceiveData[6] & 0xff) << 8 | ReceiveData[7] & 0xff);
                                    if (datatemp >= 0)
                                    {
                                       CalibrahumidityLabel.Text = datatemp.ToString();
                                    }
                                    else
                                    {
                                       datatemp = 0xffff - datatemp;
                                       datatemp += 1;
                                       CalibrahumidityLabel.Text = (datatemp * -1).ToString();
                                    }
                                    buffer = "温度补偿：" + CalibrasoiltempLabel.Text + "℃"+"    " + "湿度补偿：" + CalibrahumidityLabel.Text;
                                    richTextBox1.AppendText(Rs485s.ByteToString(ReceiveData));
                                    break;
                                default:
                                    break;
                                }
                                richTextBox1.AppendText(buffer + "\r\n");
                                FileShare(buffer + "\r\n");
                            }
                        }

                    }
                    else
                    {
                        ///接收字符
                        richTextBox1.AppendText(System.Text.Encoding.Default.GetString(ReceiveData));

                        //16进制输出
                        //richTextBox1.AppendText(ByteToString(ReceiveData));
                        //FileShare(System.Text.Encoding.Default.GetString(ReceiveData));
                    }

                }));
            }
        }

        /// <summary>
        /// 接收文档滚动条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            /********************** 自动下拉到最后 **********************/           
            //设置光标的位置到文本尾
            richTextBox1.Select(richTextBox1.TextLength, 0);
            //滚动到控件光标处   
            richTextBox1.ScrollToCaret();

            //InitThread();
        }
 
        /// <summary>
        /// 鼠标双击清除文档显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RichTextBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Clear();
        }

        /// <summary>
        /// 鼠标右击剪切
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        /// <summary>
        /// 鼠标右击复制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        /// <summary>
        /// 鼠标右击粘贴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        /// <summary>
        /// 鼠标右击全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        /// <summary>
        /// 刷新串口ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SerialId_DropDown(object sender, EventArgs e)
        {
            string[] PortNames = SerialPort.GetPortNames();    //获取本机串口名称，存入PortNames数组中 
            SerialId.Items.Clear();
            for (int i = 0; i < PortNames.Count(); i++)
            {
               SerialId.Items.Add(PortNames[i]);   //将数组内容加载到comboBox控件中                   
             }
             if (PortNames.Length >= 1)
            {
               SerialId.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 鼠标双击清除采集时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CollectTime_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CollectTime.Clear();
        }

        /// <summary>
        /// 土壤温度标定控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StempCalibra_Click(object sender, EventArgs e)
        {           
            timer.Stop();
         
            richTextBox1.AppendText(textSoilTemp.Text);
            int data = Convert.ToInt16(Convert.ToDouble(textSoilTemp.Text) * 10);
            TempHumiditys.SetSoilTemp(data);
            Thread.Sleep(2000);
    
            timer.Start();
        }

        /// <summary>
        /// 土壤温度清零控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StempClear_Click(object sender, EventArgs e)
        {
            TempHumiditys.ClearSoilTemp();
        }

        private void SHumidCalibra_Click(object sender, EventArgs e)
        {
            timer.Stop();

            richTextBox1.AppendText(textSoilHumid.Text);
            int data = Convert.ToInt16(Convert.ToDouble(textSoilHumid.Text));
            TempHumiditys.SetSoilHumidity(data);
            Thread.Sleep(2000);

            timer.Start();
        }

        private void SHumidClear_Click(object sender, EventArgs e)
        {
            timer.Stop();
            TempHumiditys.ClearSoilHumidity();
            Thread.Sleep(2000);

            timer.Start();
        }

        private void SoilCheck_Click(object sender, EventArgs e)
        {
            timer.Stop();
            TempHumiditys.CheckSoilTempHumidity();
            Thread.Sleep(2000);

            timer.Start();
        }
    }
}
