using System;
using System.Linq;
using System.Collections.Generic;
using RandomStuff.MD5;

namespace RandomStuff
{
    class RandomNumbersMD5
    {
        private readonly MD5Gen _md5Gen;
        public RandomNumbersMD5(MD5Gen mD5Gen)
        {
            _md5Gen = mD5Gen;
        }
        public void run()
        {
            Random r = new Random();
            var Numbers = Enumerable.Range(0, 10)
                                    .Select(i => r.Next(100))
                                    .ToList();
            Numbers.ForEach( m => Console.WriteLine(m));
            Console.WriteLine();
            List<KeyValuePair<int, string>> myMD5Res = new List<KeyValuePair<int, string>>();
            Numbers.ForEach(m => myMD5Res.Add( new KeyValuePair<int, string>(m, _md5Gen.GetMD5(m))));
            myMD5Res.ForEach(i => Console.WriteLine($"{i.Key} -> {i.Value}"));
        }
    }
}