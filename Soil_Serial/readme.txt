string转byte[]:

byte[] byteArray = System.Text.Encoding.Default.GetBytes ( str );

byte[]转string：

string str = System.Text.Encoding.Default.GetString ( byteArray );

string转ASCII byte[]:

byte[] byteArray = System.Text.Encoding.ASCII.GetBytes ( str );

ASCII byte[]转string:

string str = System.Text.Encoding.ASCII.GetString ( byteArray );

?文本转换

Convert.ToInt32??(String,?Int32)；Convert.ToByte??(Int32);??

String.Format：数据格式转换后以字符串输出，例子：
string.Format("{0:X2}", 12)  输出:0C

字符：ASCCI码显示

DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");


文件读写+每秒时间保存

