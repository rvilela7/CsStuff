using System;
using System.Linq;
using System.Collections.Generic;

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
            var myLista = Enumerable.Range(0, 10)
                                    .Select(i => r.Next(100))
                                    .ToList();
            myLista.ForEach( m => Console.WriteLine(m));
            Console.WriteLine();
            List<KeyValuePair<int, string>> myMD5Res = new List<KeyValuePair<int, string>>();
            myLista.ForEach(m => myMD5Res.Add( new KeyValuePair<int, string>(m, _md5Gen.GetMD5(m))));
            myMD5Res.ForEach(i => Console.WriteLine($"{i.Key} -> {i.Value}"));
        }
    }
}