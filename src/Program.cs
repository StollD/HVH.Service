﻿/**
 * HVH.Service - Service that can manage client computers
 * Copyright (c) Kai Münch, Dorian Stoll 2016
 * Licensed under the terms of the MIT License (Dorian Stoll), or All Rights Reserved (Kai Münch)
 */

using System.ServiceProcess;

namespace HVH.Service
{
    /// <summary>
    /// The class that registers the services in windows
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Main entry point for the application
        /// </summary>
        public static void Main()
        {
            ServiceBase[] ServicesToRun = 
            {
                new ClientService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
