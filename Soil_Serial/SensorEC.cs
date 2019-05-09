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
        /// 显示当前电导率
        /// </summary>
        private LinkLabel _CurrentEcLabel;

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

        private LinkLabel _CalibraTempLabel;
        private LinkLabel _CalibraECALabel;
        private LinkLabel _CalibraECBLabel;
        private LinkLabel _CalibraECCLabel;

        private Button _ECAbutton;
        private Button _ECBbutton;
        private Button _ECCbutton;

        private RichTextBox _RichTextBox1;

        public void InitWidget(SerialPort SerialDevice, LinkLabel ECTempLabel, TextBox textECTemp, Button ECtempCalibra, Button ECTempClear, LinkLabel CurrentEcLabel,
                               LinkLabel ECALabel, TextBox textEC_A, LinkLabel ECBLabel, TextBox textEC_B, LinkLabel ECCLabel, TextBox textEC_C, Button ECCalibra,
                               Button ECClear, Button ECCheck, LinkLabel CalibraTempLabel, LinkLabel CalibraECALabel, LinkLabel CalibraECBLabel,
                               LinkLabel CalibraECCLabel, Button ECAbutton, Button ECBbutton, Button ECCbutton,RichTextBox RichTextBox1)

        {
            _SerialDevice = SerialDevice;
            ///温度控件
            _ECTempLabel = ECTempLabel;
            _textECTemp = textECTemp;
            _ECtempCalibra = ECtempCalibra;
            _ECTempClear = ECTempClear;

            ///电导率控件
            _CurrentEcLabel = CurrentEcLabel;

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

            _CalibraTempLabel = CalibraTempLabel;
            _CalibraECALabel = CalibraECALabel;
            _CalibraECBLabel = CalibraECBLabel;
            _CalibraECCLabel = CalibraECCLabel;

            _ECAbutton = ECAbutton;
            _ECBbutton = ECBbutton;
            _ECCbutton = ECCbutton;

            _RichTextBox1 = RichTextBox1;
        }

        public void EnableControlProper()
        {
            ///温度控件
            _ECTempLabel.Enabled = true; 
            _textECTemp.Enabled = true;
            _ECtempCalibra.Enabled = true;
            _ECTempClear.Enabled = true;

            _CurrentEcLabel.Enabled = true;

            /// 0<EC<0.5控件
            _ECALabel.Enabled = true;
            _textEC_A.Enabled = true;

            ///1<EC<3控件
            _ECBLabel.Enabled = true;
            _textEC_B.Enabled = true;

            ///9<EC<10控件
            _ECCLabel.Enabled = true;
            _textEC_C.Enabled = true;

            _ECCalibra.Enabled = true;
            _ECClear.Enabled = true;

            ///标定查询
            _ECCheck.Enabled = true;

            _CalibraTempLabel.Enabled = true;
            _CalibraECALabel.Enabled = true;
            _CalibraECBLabel.Enabled = true;
            _CalibraECCLabel.Enabled = true;

            _ECAbutton.Enabled = true;
            _ECBbutton.Enabled = true;
            _ECCbutton.Enabled = true;
        }

        public void DisableControlProper()
        {
            ///温度控件
            _ECTempLabel.Enabled = false;
            _textECTemp.Enabled = false;
            _ECtempCalibra.Enabled = false;
            _ECTempClear.Enabled = false;

            _CurrentEcLabel.Enabled = false;

            /// 0<EC<0.5控件
            _ECALabel.Enabled = false;
            _textEC_A.Enabled = false;

            ///1<EC<3控件
            _ECBLabel.Enabled = false;
            _textEC_B.Enabled = false;

            ///9<EC<10控件
            _ECCLabel.Enabled = false;
            _textEC_C.Enabled = false;

            _ECCalibra.Enabled = false;
            _ECClear.Enabled = false;

            ///标定查询
            _ECCheck.Enabled = false;

            _CalibraTempLabel.Enabled = false;
            _CalibraECALabel.Enabled = false;
            _CalibraECBLabel.Enabled = false;
            _CalibraECCLabel.Enabled = false;

            _ECAbutton.Enabled = false;
            _ECBbutton.Enabled = false;
            _ECCbutton.Enabled = false;
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

            //_ECALabel.Text = "0.159";
            //_ECBLabel.Text = "0.857";
            //_ECCLabel.Text = "4.948";

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

        /// <summary>
        /// 查询土壤电导率标定
        /// </summary>
        public void CheckSoilEC()
        {
            Byte[] SendCmds = new Byte[8] { 0xf8, 0x07, 0x03, 0x07, 0x00, 0x00, 0x00, 0x00 };
            Rs485s.GetCrc(SendCmds, 6);
            _SerialDevice.Write(SendCmds, 0, 8);
        }
    }
}