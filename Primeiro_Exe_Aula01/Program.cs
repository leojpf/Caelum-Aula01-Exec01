using Microsoft.AspNetCore.Hosting;
using System;

namespace Primeiro_Exe_Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebHost host = new WebHostBuilder()
                .UseStartup<StartUp>()
                .UseKestrel()
                .Build();

            Console.WriteLine("Hello World!");

            host.Run();
        }
    }
}
