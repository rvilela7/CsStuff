namespace RandomStuff.MD5
{
    public interface IMD5Gen
    {
        string GetMD5(string input);
        string GetMD5(int input);
    }
}