/* 
Class:			ISTA 421 Developing Cloud Applications
Student:		Paul J. Ratliff
Instructor:		Christine Lee
Date:			09/24/2020
Description:	This is a completed turtorial from Pro ASP.NET Core:3 
                Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages. By: Adam Freeman 
Revised:
Revised by:
Revision:

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SportsStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
