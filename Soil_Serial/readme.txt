stringתbyte[]:

byte[] byteArray = System.Text.Encoding.Default.GetBytes ( str );

byte[]תstring��

string str = System.Text.Encoding.Default.GetString ( byteArray );

stringתASCII byte[]:

byte[] byteArray = System.Text.Encoding.ASCII.GetBytes ( str );

ASCII byte[]תstring:

string str = System.Text.Encoding.ASCII.GetString ( byteArray );

?�ı�ת��

Convert.ToInt32??(String,?Int32)��Convert.ToByte??(Int32);??

String.Format�����ݸ�ʽת�������ַ�����������ӣ�
string.Format("{0:X2}", 12)  ���:0C

�ַ���ASCCI����ʾ

DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");


�ļ���д+ÿ��ʱ�䱣��

