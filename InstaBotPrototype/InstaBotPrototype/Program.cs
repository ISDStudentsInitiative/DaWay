﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using InstaBotPrototype.Extensions;

namespace InstaBotPrototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).CheckConnection().StartIntegrator().Run();
        }
        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
