using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace RandomStuff
{
    public class MD5Gen
    {
        public MD5Gen()
        {
        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            var myLista = Enumerable.Range(0, r.Next(100))
                                    .Select(i => r.Next(10))
                                    .ToList();

            var MD5Gen = new MD5Gen();

            var myMD5List = myLista.Select(m => MD5Gen.CreateMD5(m.ToString())).ToList();

            myMD5List.ForEach(i => Console.WriteLine(i));
        }
    }
}