using System.Threading;
using System.Threading.Tasks;

namespace Async.Classes
{
    public class MyTask
    {
        public void MySleep() => Thread.Sleep(4000);
        public async Task MySleep2() => await Task.Delay(4000);

        public async Task<string> MyTest1() { 
            await MySleep2();
            await MySleep2();
            await MySleep2();
            //MySleep();

            Task.WaitAll();
            return "reply";        
        }
    }
}