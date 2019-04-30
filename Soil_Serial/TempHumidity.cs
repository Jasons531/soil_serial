
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


        public void StempCalibra( )
        {
            _RichTextBox1.Text += _textSoilTemp.Text;
        }

        public void StempClear()
        {
           _RichTextBox1.Clear();
        }
    }
}