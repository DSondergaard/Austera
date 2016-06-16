using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string path = Directory.CreateDirectory("Pictures").FullName;
            for (int i = 1; i <= 699; i++)
            {
                string localfile = Path.Combine(path, "Pic" + i.ToString("D3") + ".png");
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile("http://www.monsterstrikedatabase.com/monsters/big/" + i + ".png", localfile);
                        counter++;
                        Console.WriteLine(counter + " files downloaded");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("No file found for index: " + i);
                }
                
            }
            Console.WriteLine("Finished");
            Console.ReadLine();

        }
    }
}
