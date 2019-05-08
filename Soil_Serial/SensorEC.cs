using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Soil_Serial
{
    internal class SensorEC
    {
        public SensorEC()
        {

        }
        private Rs485 Rs485s = new Rs485();
        private SerialPort _SerialDevice;
        /// <summary>
        /// 温度
        /// </summary>
        private LinkLabel _ECTempLabel;
        private TextBox _textECTemp;
        private Button _ECtempCalibra;
        private Button _ECTempClear;
        /// <summary>
        /// EC
        /// </summary>
        /// 0<EC<0.5
        private LinkLabel _ECALabel;
        private TextBox _textEC_A;
        private Button _ECACalibra;
        private Button _ECAClear;

        /// 1<EC<3
        private LinkLabel _ECBLabel;
        private TextBox _textEC_B;
        private Button _ECBCalibra;
        private Button _ECBClear;

        /// 9<EC<10
        private LinkLabel _ECCLabel;
        private TextBox _textEC_C;
        private Button _ECCCalibra;
        private Button _ECCClear;

        private Button _ECCheck;

        private RichTextBox _RichTextBox1;

        public void InitWidget(SerialPort SerialDevice, LinkLabel ECTempLabel, TextBox textECTemp, Button ECtempCalibra, Button ECTempClear,
                               LinkLabel ECALabel, TextBox textEC_A, Button ECACalibra, Button ECAClear,
                               LinkLabel ECBLabel, TextBox textEC_B, Button ECBCalibra, Button ECBClear,
                               LinkLabel ECCLabel, TextBox textEC_C, Button ECCCalibra, Button ECCClear,
                               Button ECCheck, RichTextBox RichTextBox1)
        {
            _SerialDevice = SerialDevice;
            ///温度控件
            _ECTempLabel = ECTempLabel;
            _textECTemp = textECTemp;
            _ECtempCalibra = ECtempCalibra;
            _ECTempClear = ECTempClear;

            /// 0<EC<0.5控件
            _ECALabel = ECALabel;
            _textEC_A = textEC_A;
            _ECACalibra = ECACalibra;
            _ECAClear = ECAClear;

            ///1<EC<3控件
            _ECBLabel = ECBLabel;
            _textEC_B = textEC_B;
            _ECBCalibra = ECBCalibra;
            _ECBClear = ECBClear;

            ///9<EC<10控件
            _ECCLabel = ECCLabel;
            _textEC_C = textEC_C;
            _ECCCalibra = ECCCalibra;
            _ECCClear = ECCClear;

            ///标定查询
            _ECCheck = ECCheck;

            _RichTextBox1 = RichTextBox1;
        }

        /// <summary>
        /// 获取土壤温度、EC传感器数据命令
        /// </summary>
        public void GetSoilTempEC()
        {
            Byte[] SendCmds = new Byte[8] { 0xf8, 0x03, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00 };
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
            Byte[] SendCmds = new Byte[8] { 0xf8, 0x07, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00 };
            int Seq = 0;
            int DataTemp = Convert.ToInt16(Convert.ToDouble(_ECTempLabel.Text) * 10);

            ///加
            if (Data > DataTemp)
            {
                Seq = Data - DataTemp;
                SendCmds[3] = 0x01;
                SendCmds[4] = (byte)((Seq & 0xff00) >> 8);
                SendCmds[5] = (byte)((Seq & 0x00ff) >> 0);
            }
            else if (Data < DataTemp)
            {
                Seq = DataTemp - Data;
                SendCmds[3] = 0x02;
                SendCmds[4] = (byte)((Seq & 0xff00) >> 8);
                SendCmds[5] = (byte)((Seq & 0x00ff) >> 0);
            }
            Rs485s.GetCrc(SendCmds, 6);
            _SerialDevice.Write(SendCmds, 0, 8);
            //_RichTextBox1.AppendText(Rs485s.ByteToString(SendCmds));
        }

        /// <summary>
        /// 清除土壤湿度标定
        /// </summary>
        public void ClearSoilTemp()
        {
            Byte[] SendCmds = new Byte[8] { 0xf8, 0x07, 0x03, 0x03, 0x00, 0x00, 0x00, 0x00 };
            Rs485s.GetCrc(SendCmds, 6);
            _SerialDevice.Write(SendCmds, 0, 8);
        }
    }
}