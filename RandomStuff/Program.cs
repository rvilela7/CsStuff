using System;
using RandomStuff.MD5;
namespace RandomStuff
{
    class CodeCleanTest
    {
        public int Id { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MD5Gen md5Gen = new MD5Gen();
            RandomNumbersMD5 app = new RandomNumbersMD5(md5Gen);
            app.run();

            CodeCleanTest codeClean = new CodeCleanTest();
            codeClean.Id = 1;
            Console.WriteLine(codeClean.Id.ToString());
        }
    }
}