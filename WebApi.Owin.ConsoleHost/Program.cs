using System;
using Microsoft.Owin.Hosting;
using WebApi.Owin.AppHost;

namespace WebApi.Owin.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://localhost:9998"))
            {
                Console.WriteLine("WebApi running on owin self hosted.");
                Console.WriteLine("Press any key to exit....");
                Console.ReadLine();
            }
        }
    }
}
