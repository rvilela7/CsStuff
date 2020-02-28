using System;
using System.Linq;

namespace RandomStuff
{
    using RandomStuff.MD5;
    class Application
    {
        private readonly IMD5Gen _md5Gen;
        public Application(IMD5Gen mD5Gen)
        {
            _md5Gen = mD5Gen;
        }
        public void run()
        {
            Random r = new Random();
            var myLista = Enumerable.Range(0, r.Next(100))
                                    .Select(i => r.Next(10))
                                    .ToList();
            var myMD5List = myLista.Select(m => _md5Gen.GetMD5(m.ToString())).ToList();
            myMD5List.ForEach(i => Console.WriteLine(i));
        }
    }
}