﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CsStuff
{
    class Program
    {

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

        static void Main(string[] args)
        {
            Random r = new Random();

            var myLista = Enumerable.Range(0, r.Next(100))
                                    .Select(i => r.Next(10))
                                    .ToList();

            var myMD5List = myLista.Select(m => CreateMD5(m.ToString())).ToList();

            //myLista.ForEach(i => Console.WriteLine(i));
            myMD5List.ForEach(i => Console.WriteLine(i));
        }
    }
}