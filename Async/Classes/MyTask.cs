using System.Threading;

namespace Async.Classes
{
    public static class MyTask
    {
        public static int Value { get; set; }
        public static void MySleep() => Thread.Sleep(4000);
    }
}