using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CSharp6._0Samples
{
    //Await keyword is used in catch & finally blocks which means we can perform asynchronous logging operations using this.
    public class AwaitInCatchFinallyBlocksDemo
    {
        public AwaitInCatchFinallyBlocksDemo()
        {
        }

        public async Task<string> MakeRequestAndLogFailures()
        {
            await logMethodEntrance();
            var client = new HttpClient();
            var streamTask = client.GetStringAsync("https://localHost:10000");
            try
            {
                var responseText = await streamTask;
                return responseText;
            }
            catch (System.Net.Http.HttpRequestException e) when (e.Message.Contains("301"))
            {
                await logError("Recovered from redirect", e);
                return "Site Moved";
            }
            finally
            {
                await LogMethodExit();
                client.Dispose();
            }
        }

        private static Task<bool> LogMethodExit()
        {
            Console.WriteLine("LogMethodExit");
            return Task.FromResult<bool>(true);
        }

        private static Task<bool> logError(string v, System.Net.Http.HttpRequestException e)
        {
            Console.WriteLine("LogError");
            return Task.FromResult<bool>(true);
        }

        private static Task<bool> logMethodEntrance()
        {
            Console.WriteLine("LogMethodEntrance");
            return Task.FromResult<bool>(true);
        }

        public static void Main(string[] arg)
        {
            AwaitInCatchFinallyBlocksDemo demo = new AwaitInCatchFinallyBlocksDemo();
            var result = demo.MakeRequestAndLogFailures();
        }
    }
}
