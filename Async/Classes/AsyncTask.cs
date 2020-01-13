using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    public class AsyncTask
    {
        public async Task<string> ReadTxtFile()
        {
            using (var sr = new StreamReader(File.Open("test.txt", FileMode.Open)))
            {
                return await sr.ReadToEndAsync();
            }
        }

        public string ReadFileSync1()
        {
            Task.Delay(2000).Wait();
            return "content1";
        }

        public string ReadFileSync2()
        {
            Task.Delay(2000).Wait();
            return "content2";
        }

        public string ReadFileSync3()
        {
            Task.Delay(2000).Wait();
            return "content3";
        }

        public async Task DoSomething()
        {
            await Task.Delay(2000);
        }
        public async Task<int> Sum(int a, int b)
        {
            var result = await Task.FromResult(a + b);
            return result;
        }

        public async Task<string> ReadFile1()
        {
            await Task.Delay(3000);
            return "file1";
        }

        public async Task<string> ReadFile2()
        {
            await Task.Delay(4000);
            return "file2";
        }

        public async Task<string> ReadFile3()
        {
            await Task.Delay(2000);
            return "file3";
        }
    }
}