namespace RandomStuff
{
    using RandomStuff.MD5;
    class Program
    {
        static void Main(string[] args)
        {
            MD5Gen md5Gen = new MD5Gen();
            Application app = new Application(md5Gen);
            app.run();
        }
    }
}