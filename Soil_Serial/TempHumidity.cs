
using System;
using System.IO.Ports;
using System.Windows.Forms;

/// <summary>
/// 土壤温湿度标定文件
/// 获取串口数据、控件事件
/// </summary>
namespace Soil_Serial
{
    public class TempHumidity
    {
        private Rs485 Rs485s = new Rs485();


        private SerialPort _SerialDevice;
        /// <summary>
        /// 温度
        /// </summary>
        private TextBox   _textSoilTemp;
        private CheckBox  _SoilTempcheckBox;
        private Button    _StempCalibra;
        private Button    _StempClear;
        /// <summary>
        /// 湿度
        /// </summary>
        private TextBox   _textSoilHumid;
        private CheckBox  _SoilHumidcheckBox;
        private Button    _SHumidCalibra;
        private Button    _SHumidClear;
        private Button    _SoilCheck;

        private RichTextBox _RichTextBox1;

        public void InitWidget(SerialPort SerialDevice, TextBox textSoilTemp,  CheckBox SoilTempcheckBox,  Button StempCalibra,  Button StempClear,
                                TextBox textSoilHumid, CheckBox SoilHumidcheckBox, Button SHumidCalibra, Button SHumidClear, Button SoilCheck, RichTextBox RichTextBox1)
        {
            _SerialDevice = SerialDevice;
            ///温度控件
            _textSoilTemp = textSoilTemp;
            _SoilTempcheckBox = SoilTempcheckBox;
            _StempCalibra = StempCalibra;
            _StempClear = StempClear;

            ///湿度控件
            _textSoilHumid = textSoilHumid;
            _SoilHumidcheckBox = SoilHumidcheckBox;
            _SHumidCalibra = SHumidCalibra;
            _SHumidClear = SHumidClear;

            ///标定查询
            _SoilCheck = SoilCheck;

            _RichTextBox1 = RichTextBox1;
        }

        /// <summary>
        /// 获取土壤温湿度传感器数据命令
        /// </summary>
        public void GetSoilTempHumidity()
        {
            Byte[] SendCmds = new Byte[8] { 0xf9, 0x03, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00 };
            Rs485s.GetCrc(SendCmds, 6);
            _SerialDevice.Write(SendCmds, 0, 8);    
            //_RichTextBox1.AppendText(Rs485s.ByteToString(SendCmds));
        }

        /// <summary>
        /// 土壤温度标定
        /// </summary>
        /// <param name="Data"></param>
        /// <param name="mode"></param>
        public void SetSoilTemp(int Data)
        {
            Byte[] SendCmds = new Byte[8] { 0xf9, 0x07, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00 };

            ///加
            if (Data > 0)
            {
                SendCmds[3] = 0x01;
                SendCmds[4] = (byte)((Data & 0xff00) >> 8);
                SendCmds[5] = (byte)((Data & 0x00ff) >> 0);                
            }
            else if (Data < 0)
            {
                Data *= -1;
                SendCmds[3] = 0x02;
                SendCmds[4] = (byte)((Data & 0xff00) >> 8);
                SendCmds[5] = (byte)((Data & 0x00ff) >> 0);              
            }
            Rs485s.GetCrc(SendCmds, 6);
            _SerialDevice.Write(SendCmds, 0, 8);
            _RichTextBox1.AppendText(Rs485s.ByteToString(SendCmds));
        }

        /// <summary>
        /// 清除土壤温度标定
        /// </summary>
        public void ClearSoilTemp()
        {
            Byte[] SendCmds = new Byte[8] { 0xf9, 0x07, 0x03, 0x03, 0x00, 0x00, 0x00, 0x00 };
            Rs485s.GetCrc(SendCmds, 6);
            _SerialDevice.Write(SendCmds, 0, 8);
        }

        /// <summary>
        /// 土壤湿度标定
        /// </summary>
        /// <param name="Data"></param>
        /// <param name="mode"></param>
        public void SetSoilHumidity(int Data)
        {
            Byte[] SendCmds = new Byte[8] { 0xf9, 0x07, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00 };

            ///加
            if(Data > 0)
            {
                SendCmds[3] = 0x05;
                SendCmds[4] = (byte)((Data & 0xff00) >> 8);
                SendCmds[5] = (byte)((Data & 0x00ff) >> 0);                
            }
            else if (Data < 0)
            {
                Data *= -1;
                SendCmds[3] = 0x06;
                SendCmds[4] = (byte)((Data & 0xff00) >> 8);
                SendCmds[5] = (byte)((Data & 0x00ff) >> 0);                         
            }
            Rs485s.GetCrc(SendCmds, 6);
            _SerialDevice.Write(SendCmds, 0, 8);
            _RichTextBox1.AppendText(Rs485s.ByteToString(SendCmds));
        }

        /// <summary>
        /// 清除土壤湿度标定
        /// </summary>
        public void ClearSoilHumidity()
        {
            Byte[] SendCmds = new Byte[8] { 0xf9, 0x07, 0x03, 0x07, 0x00, 0x00, 0x00, 0x00 };
            Rs485s.GetCrc(SendCmds, 6);
            _SerialDevice.Write(SendCmds, 0, 8);
        }

        /// <summary>
        /// 查询土壤温湿度补偿数据
        /// </summary>
        public void CheckSoilTempHumidity()
        {
            Byte[] SendCmds = new Byte[8] { 0xf9, 0x07, 0x03, 0x08, 0x00, 0x00, 0x00, 0x00 };
            Rs485s.GetCrc(SendCmds, 6);
            _SerialDevice.Write(SendCmds, 0, 8);
        }
    }
}