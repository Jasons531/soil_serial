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
        private bool SysStartTime = true;
        private DateTime dt1;
        private DateTime dt2;
        private bool SoilECMode = false;

        internal TempHumidity TempHumiditys1 { get => TempHumiditys; set => TempHumiditys = value; }

        public Form1()
        {
            InitializeComponent();
            InitSerialConfig();
            TempHumiditys.InitWidget(SerialDevice, textSoilTemp, SoilTempcheckBox, StempCalibra, StempClear,
                                    textSoilHumid, SoilHumidcheckBox, SHumidCalibra, SHumidClear, SoilCheck, richTextBox1);
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
        }

        ///// <summary>
        ///// RS485_CRC校验
        ///// </summary>
        ///// <param name="data"></param>
        ///// <param name="len"></param>
        //private void Rs485Crc(byte[] data, byte len)
        //{
        //    ushort result = 0xffff;
        //    byte i, j;

        //    for (i = 0; i < len; i++)
        //    {
        //        result ^= data[i];
        //        for (j = 0; j < 8; j++)
        //        {
        //            result = (result & 1) != 0 ? (ushort)((result >> 1) ^ 0xA001) : (ushort)(result >> 1);
        //        }
        //    }

        //    data[len] = (byte)(result & 0x00ff);
        //    data[++len] = (byte)((result & 0xff00) >> 8);
        //}

        /// <summary>
        /// 获取土壤温湿度传感器数据命令
        /// </summary>
        private void GetSoilTempHumidity()
        {
            Byte[] SendCmds = new Byte[8] { 0xf9, 0x03, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00 };
            Rs485s.GetCrc(SendCmds, 6);

            SerialDevice.Write(SendCmds, 0, 8);
            //byte[] bytes = System.Text.Encoding.Default.GetBytes(str);
            //serialPort1.Write(bytes, 0, bytes.Length);
            richTextBox1.AppendText(ByteToString(SendCmds)); 
        }

        /// <summary>
        /// 获取土壤EC传感器数据命令
        /// </summary>
         private void GetSoilTempEC()
        {
            Byte[] SendCmds = new Byte[8] { 0xf8, 0x03, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00 };

            Rs485s.GetCrc(SendCmds, 6);

            SerialDevice.Write(SendCmds, 0, 8);
            //byte[] bytes = System.Text.Encoding.Default.GetBytes(str);
            //serialPort1.Write(bytes, 0, bytes.Length);
            richTextBox1.AppendText(ByteToString(SendCmds));
        }

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

                        if (SetModebox.Text == "土壤温湿度")
                        {
                            //获取土壤温湿度传感器数据
                            GetSoilTempHumidity();
                        }
                        else if (SetModebox.Text == "土壤电导率")
                        {
                            //获取土壤EC传感器数据
                            GetSoilTempEC();
                        }

                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Error:" + ex.Message, "Error");
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

                    SoilTemp = (ReceiveData[3] & 0xff) << 8 | ReceiveData[4] & 0xff;

                    if (ReceiveData[0] == 0xf8)
                    {
                        SoilECMode = true;
                        SoilEC = (ReceiveData[5] & 0xff) << 8 | ReceiveData[6] & 0xff;
                    }
                    else if (ReceiveData[0] == 0xf9)
                    {
                        SoilECMode = false;
                        SoilHumidity = (ReceiveData[5] & 0xff) << 8 | ReceiveData[6] & 0xff;
                    }

                    if (FirstSysTime)
                    {
                        dt1 = DateTime.Parse(DateTime.Now.ToString());
                        richTextBox1.AppendText(DateTime.Now.ToString("【HH:mm:ss:fff】"));
                        FirstSysTime = false;
                        SysStartTime = false;
                    }
                    if (SysStartTime)
                    {
                        SysStartTime = false;
                        dt1 = DateTime.Parse(DateTime.Now.ToString());                     
                    }                  
                    dt2 = DateTime.Parse(DateTime.Now.ToLocalTime().ToString());

                    //利用TimeSpan计算时间差 
                    TimeSpan ts1 = new TimeSpan(dt1.Ticks);
                    TimeSpan ts2 = new TimeSpan(dt2.Ticks);
                    TimeSpan ts3 = ts2.Subtract(ts1); //ts2-ts1
                    int sumMilliSeconds = int.Parse(ts3.TotalMilliseconds.ToString()); //得到相差毫秒数

                    if(CollectTime.Text == "采集时间(最好>5s)")
                    {
                        CollectTime.Text = "5";
                    }
             
                    if (sumMilliSeconds >= Convert.ToInt32(CollectTime.Text) * 1000) //判断是否大于CollectTime.Text
                    {
                        SysStartTime = true;
                        richTextBox1.AppendText(DateTime.Now.ToString("【HH:mm:ss:fff】"));
                        FileShare(DateTime.Now.ToString("【HH:mm:ss:fff】"));
                    }

                    ///接收字符
                    //richTextBox1.AppendText(System.Text.Encoding.Default.GetString(ReceiveData));

                    //16进制输出
                    //richTextBox1.AppendText(ByteToString(ReceiveData));
                    if (SoilECMode)
                    {
                        richTextBox1.AppendText("土壤电导率: " + "温度: " + (float)SoilTemp / 10 + "℃" + "   " + "EC: " + (float)SoilEC / 1000 + "ds/cm");
                    }
                    else
                    {
                        richTextBox1.AppendText("土壤温湿度: " + "温度: " + (float)SoilTemp / 10 + "℃" + "   " + "湿度: " + (float)SoilHumidity / 10 + "％");
                    }

                    FileShare(System.Text.Encoding.Default.GetString(ReceiveData));                       
                }));
            }
        }

        /// <summary>
        /// byte转换hex字符串输出
        /// </summary>
        /// <param name="InBytes"></param>
        /// <returns></returns>
        public static string ByteToString(byte[] InBytes)
        {
            string StringOut = "";
            foreach (byte InByte in InBytes)
            {
                StringOut = StringOut + String.Format("{0:X2} ", InByte); ///相当于byte转hex,hex.tostring转为字符串
            }
            return StringOut;
        }

        /// <summary>
        /// 字符串转换byte
        /// </summary>
        /// <param name="InString"></param>
        /// <returns></returns>
        public static byte[] StringToByte(string InString)
        {
            string[] ByteStrings;
            ByteStrings = InString.Split(" ".ToCharArray());
            byte[] ByteOut;
            ByteOut = new byte[ByteStrings.Length - 1];
            for (int i = 0; i == ByteStrings.Length - 1; i++)
            {
                ByteOut[i] = Convert.ToByte(("0x" + ByteStrings[i]));
            }
            return ByteOut;
        }

        /// <summary>
        /// 接收文档滚动条
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            /********************** 自动下拉到最后 **********************/
            //让文本框获取焦点   
            richTextBox1.Focus();
            //设置光标的位置到文本尾   
            richTextBox1.Select(richTextBox1.TextLength, 0);
            //滚动到控件光标处   
            richTextBox1.ScrollToCaret();
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
            TempHumiditys.StempCalibra();
        }

        /// <summary>
        /// 土壤温度清零控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StempClear_Click(object sender, EventArgs e)
        {
            TempHumiditys.StempClear();
        }

    }
}
