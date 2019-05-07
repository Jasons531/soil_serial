using System;

namespace Soil_Serial
{
    internal class Rs485
    {
        /// <summary>
        /// byte转换hex字符串输出
        /// </summary>
        /// <param name="InBytes"></param>
        /// <returns></returns>
        public string ByteToString(byte[] InBytes)
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
        public byte[] StringToByte(string InString)
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
        /// RS485_CRC校验
        /// </summary>
        /// <param name="data"></param>
        /// <param name="len"></param>
        public void GetCrc(byte[] data, byte len)
        {
            ushort result = 0xffff;
            byte i, j;

            for (i = 0; i < len; i++)
            {
                result ^= data[i];
                for (j = 0; j < 8; j++)
                {
                    result = (result & 1) != 0 ? (ushort)((result >> 1) ^ 0xA001) : (ushort)(result >> 1);
                }
            }

            data[len] = (byte)(result & 0x00ff);
            data[++len] = (byte)((result & 0xff00) >> 8);
        }
    }
}