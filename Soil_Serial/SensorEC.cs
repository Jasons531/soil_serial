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

        /// 1<EC<3
        private LinkLabel _ECBLabel;
        private TextBox _textEC_B;

        /// 9<EC<10
        private LinkLabel _ECCLabel;
        private TextBox _textEC_C;
        private Button _ECCalibra;
        private Button _ECClear;

        private Button _ECCheck;

        private RichTextBox _RichTextBox1;

        public void InitWidget(SerialPort SerialDevice, LinkLabel ECTempLabel, TextBox textECTemp, Button ECtempCalibra, Button ECTempClear,
                               LinkLabel ECALabel, TextBox textEC_A, LinkLabel ECBLabel, TextBox textEC_B, LinkLabel ECCLabel, TextBox textEC_C,
                               Button ECCalibra, Button ECClear, Button ECCheck, RichTextBox RichTextBox1)
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

            ///1<EC<3控件
            _ECBLabel = ECBLabel;
            _textEC_B = textEC_B;

            ///9<EC<10控件
            _ECCLabel = ECCLabel;
            _textEC_C = textEC_C;

            _ECCalibra = ECCalibra;
            _ECClear = ECClear;

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

        public int[] SetSoilEC(double[] Data)
        {
            Byte[] SendCmds = new Byte[12] { 0xf8, 0x07, 0x03, 0x05, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            
            double[] retudata = new double[3];
            int[] SensorData = new int[3];
            //int DataTemp = Convert.ToInt16(Convert.ToDouble(_ECTempLabel.Text) * 10);

            _ECALabel.Text = "0.159";
            _ECBLabel.Text = "0.857";
            _ECCLabel.Text = "4.948";

            if (_ECALabel.Text != "00.000" && _ECBLabel.Text != "00.000" && _ECCLabel.Text != "00.000")
            {
                retudata = Rs485s.Trixsolve(Convert.ToDouble(_ECALabel.Text), Convert.ToDouble(_ECBLabel.Text), Convert.ToDouble(_ECCLabel.Text),
                                 Data[0], Data[1], Data[2]);
                
                SensorData[0] = (int)(retudata[0] * 1000);
                SensorData[1] = (int)(retudata[1] * 1000);
                SensorData[2] = (int)(retudata[2] * 1000);

                _RichTextBox1.AppendText(SensorData[0].ToString()+"+");
                _RichTextBox1.AppendText(SensorData[1].ToString() + "+");
                _RichTextBox1.AppendText(SensorData[2].ToString() + "+");
                ///EC_L
                SendCmds[4] = (byte)((SensorData[0] & 0xff00) >> 8);
                SendCmds[5] = (byte)((SensorData[0] & 0x00ff) >> 0);
                ///EC_M
                SendCmds[6] = (byte)((SensorData[1] & 0xff00) >> 8);
                SendCmds[7] = (byte)((SensorData[1] & 0x00ff) >> 0);
                ///EC_H
                SendCmds[8] = (byte)((SensorData[2] & 0xff00) >> 8);
                SendCmds[9] = (byte)((SensorData[2] & 0x00ff) >> 0);

                Rs485s.GetCrc(SendCmds, 10);
                _SerialDevice.Write(SendCmds, 0, 12);
                //_RichTextBox1.AppendText(Rs485s.ByteToString(SendCmds));                
            }
            else
            {
                MessageBox.Show("请确保土壤电导率传感器三点读数不为0");
            }
            return SensorData;
        }

        /// <summary>
        /// 清除土壤电导率标定
        /// </summary>
        public void ClearSoilEC()
        {
            Byte[] SendCmds = new Byte[8] { 0xf8, 0x07, 0x03, 0x06, 0x00, 0x00, 0x00, 0x00 };
            Rs485s.GetCrc(SendCmds, 6);
            _SerialDevice.Write(SendCmds, 0, 8);
        }

        public void CheckSoilEC()
        {
            Byte[] SendCmds = new Byte[8] { 0xf8, 0x07, 0x03, 0x07, 0x00, 0x00, 0x00, 0x00 };
            Rs485s.GetCrc(SendCmds, 6);
            _SerialDevice.Write(SendCmds, 0, 8);
        }
    }
}