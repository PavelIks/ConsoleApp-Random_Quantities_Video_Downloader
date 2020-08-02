using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace VideoDownloaderInVaryingQuantities
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int j = new Random().Next(5, 55);
                for (int i = 0; i < j; i++)
                {
                    Console.Title = j.ToString();
                    Task.Factory.StartNew
                        (
                            () =>
                            {
                                GetFile("https://r4---sn-jucj-0qpz.googlevideo.com/videoplayback?expire=1596386075&ei=u5YmX6zLOIHHwASi1bLQCQ&ip=200.225.198.170&id=o-AOx8F_EKmPtOkcc4rCS6E9l11zP7wAWuvhQAQrR_wOay&itag=18&source=youtube&requiressl=yes&mh=iy&mm=31%2C29&mn=sn-jucj-0qpz%2Csn-bg07dnsy&ms=au%2Crdu&mv=m&mvi=4&pl=18&initcwndbps=825000&vprv=1&mime=video%2Fmp4&gir=yes&clen=531614&ratebypass=yes&dur=10.750&lmt=1595386105484706&mt=1596364347&fvip=4&fexp=23883098&c=WEB&txp=5431432&sparams=expire%2Cei%2Cip%2Cid%2Citag%2Csource%2Crequiressl%2Cvprv%2Cmime%2Cgir%2Cclen%2Cratebypass%2Cdur%2Clmt&sig=AOq0QJ8wRQIgUsTBsX7mkQIZpyIrcBoQj-0MtUiO0QpQ6pBB5GFbcfMCIQCyX8d7BdQn8I7cr2mlaLWSZ-oQLQ9BucCHG0cI5lDz8A%3D%3D&lsparams=mh%2Cmm%2Cmn%2Cms%2Cmv%2Cmvi%2Cpl%2Cinitcwndbps&lsig=AG3C_xAwRgIhAIFrUuJV7SBDQg7y0laPvb-PNrwgH5A8BUnG4BJUOxgYAiEA5K69AJNzIWUAAEOw1xiQxvpwPTcO-WWGc-xy8TxDD64%3D&video_id=NOb2cjgiTko&title=Vibing+Pug+%28Original%29+with+no+music").GetAwaiter();
                            }
                        );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }

        private async static Task GetFile(string what)
        {
            WebClient client = new WebClient();
            string name = Path.GetRandomFileName();
            await client.DownloadFileTaskAsync(new Uri(what), name + ".mp4");
            Console.WriteLine($"{name}\tCompleted");
            GC.Collect();
        }
    }
}