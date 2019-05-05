using System;

namespace Soil_Serial
{
    internal class Rs485
    {
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