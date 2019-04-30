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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soil_Serial
{
    public partial class Form1 : Form
    {
        public SerialPort SerialDevice = new SerialPort();
        private TempHumidity TempHumiditys = new TempHumidity();
        private SoilEC SoilEC = new SoilEC();
        private bool FirstSysTime = true;
        private bool SysStartTime = true;
        private DateTime dt1;
        private DateTime dt2;

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
                        SerialDevice.BaudRate = 115200;
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

        private void SerialDevice_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {       
            if (SerialDevice.IsOpen)
            {
                this.Invoke((EventHandler)(delegate
                {
                    Byte[] ReceiveData = new Byte[SerialDevice.BytesToRead]; ///接收到ARM数据格式为char - 16进制模式
                    SerialDevice.Read(ReceiveData, 0, ReceiveData.Length);
                    //16进制输出
                    //richTextBox1.AppendText(ByteToString(ReceiveData));      

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

                    richTextBox1.AppendText(System.Text.Encoding.Default.GetString(ReceiveData));
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
 
        private void RichTextBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Clear();
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

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

        private void CollectTime_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CollectTime.Clear();
        }

        private void StempCalibra_Click(object sender, EventArgs e)
        {
            TempHumiditys.StempCalibra();
        }

        private void StempClear_Click(object sender, EventArgs e)
        {
            TempHumiditys.StempClear();
        }
    }
}
