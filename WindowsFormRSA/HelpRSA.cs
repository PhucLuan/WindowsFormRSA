using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRSA
{
    /// <summary>
    /// Ký và xác thực chữ ký theo RSA
    /// </summary>
    public class HelpRSA
    {
        public byte[] encry;
        /// <summary>
        /// Ký văn bản
        /// </summary>
        /// <param name="privateKey">Khóa bí mật</param>
        /// <param name="phi">số phi (p-1)*(q-1)</param>
        /// <param name="signature">Văn bản cần ký</param>
        /// <returns>Mảng chữ ký sau khi mã hóa</returns>
        public int[] SigRSA(int privateKey, int phi, string signature)
        {
            encry = Encoding.UTF8.GetBytes(signature);
            int[] results=new int[encry.Length];
            for (int i = 0; i < encry.Length; i++)
            {
                results[i] = calMOd(encry[i], privateKey, phi);
            }
            return results;
        }
        /// <summary>
        /// Xác thực chữ lý
        /// </summary>
        /// <param name="publicKey"></param>
        /// <param name="phi"></param>
        /// <param name="signRSA"></param>
        /// <param name="encry"></param>
        /// <returns></returns>
        public bool sigAuthentication(int publicKey, int phi, int[] signRSA, byte[] encry)
        {
            //encry = Encoding.UTF8.GetBytes(signature);
            int[] Intsencry = encry.Select(x => (int)x).ToArray();
            int[] results = new int[encry.Length];
            for (int i = 0; i < encry.Length; i++)
            {
                results[i] = calMOd(signRSA[i], publicKey, phi);
            }
            return Intsencry.SequenceEqual(results);
        }
        /// <summary>
        /// Tính lũy thừa modulo với số mũ lớn a^m mod n
        /// </summary>
        /// <param name="a"></param>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int calMOd(int a, int m, int n)
        {
            int result = 1;
            for (int i = 0; i < m; i++)
            {
                result = result * a % n;
            }
            return result;
        }
    }
}
