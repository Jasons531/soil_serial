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

        /*
         * Slove a, b, c in equation y=a*x^2+b*x+c
         * y is standard EC
         * x is EC before calibration
         * Arguments    
         *input			  double x1
         *                double x2
         *                double x3
         *                double y1
         *                double y2
         *                double y3
         * output
         *                double *a
         *                double *b
         *                double *c
         * Return Type  : void
         */
        public double[] Trixsolve(double x1, double x2, double x3, double y1, double y2, double y3)
        {
            //double xx[9];
            //double yy[3];
            double[] xx = new double[9];
            double[] yy = new double[3];
            double[] data = new double[3];
            int r1;
            int r2;
            int r3;
            double maxval;
            double a21;
            int rtemp;
            xx[0] = x1 * x1;
            xx[3] = x1;
            xx[6] = 1.0;
            xx[1] = x2 * x2;
            xx[4] = x2;
            xx[7] = 1.0;
            xx[2] = x3 * x3;
            xx[5] = x3;
            xx[8] = 1.0;
            yy[0] = y1;
            yy[1] = y2;
            yy[2] = y3;
            r1 = 0;
            r2 = 1;
            r3 = 2;
            maxval = System.Math.Abs(xx[0]);
            a21 = System.Math.Abs(xx[1]);
            if (a21 > maxval)
            {
                maxval = a21;
                r1 = 1;
                r2 = 0;
            }

            if (System.Math.Abs(xx[2]) > maxval)
            {
                r1 = 2;
                r2 = 1;
                r3 = 0;
            }

            xx[r2] /= xx[r1];
            xx[r3] /= xx[r1];
            xx[3 + r2] -= xx[r2] * xx[3 + r1];
            xx[3 + r3] -= xx[r3] * xx[3 + r1];
            xx[6 + r2] = 1.0 - xx[r2];
            xx[6 + r3] -= xx[r3] * xx[6 + r1];
            if (System.Math.Abs(xx[3 + r3]) > System.Math.Abs(xx[3 + r2]))
            {
                rtemp = r2;
                r2 = r3;
                r3 = rtemp;
            }

            xx[3 + r3] /= xx[3 + r2];
            xx[6 + r3] -= xx[3 + r3] * xx[6 + r2];
            //*b = yy[r2] - yy[r1] * xx[r2];
            //*c = ((yy[r3] - yy[r1] * xx[r3]) - *b * xx[3 + r3]) / xx[6 + r3];
            //*b -= *c * xx[6 + r2];
            //*b /= xx[3 + r2];
            //*a = ((yy[r1] - *c * xx[6 + r1]) - *b * xx[3 + r1]) / xx[r1];
            data[1] = yy[r2] - yy[r1] * xx[r2];
            data[2] = ((yy[r3] - yy[r1] * xx[r3]) - data[1] * xx[3 + r3]) / xx[6 + r3];
            data[1] -= data[2] * xx[6 + r2];
            data[1] /= xx[3 + r2];
            data[0] = ((yy[r1] - data[2] * xx[6 + r1]) - data[1] * xx[3 + r1]) / xx[r1];
            return data;
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