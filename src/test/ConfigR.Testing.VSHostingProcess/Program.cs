﻿// <copyright file="Program.cs" company="ConfigR contributors">
//  Copyright (c) ConfigR contributors. (configr.net@gmail.com)
// </copyright>

namespace ConfigR.Testing.VSHostingProcess
{
    using System;
    using Common.Logging;
    using Common.Logging.Simple;
    using ConfigR;

    public static class Program
    {
        public static void Main()
        {
            LogManager.Adapter = new ConsoleOutLoggerFactoryAdapter(LogLevel.Trace, false, true, true, null);

            Console.WriteLine(Config.Global.Get<string>("greeting"));

            Console.WriteLine("Brutalize a key with your favourite finger to exit.");
            Console.ReadKey();
        }
    }
}
