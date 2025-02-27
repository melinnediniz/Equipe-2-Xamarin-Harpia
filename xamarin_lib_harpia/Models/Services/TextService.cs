﻿using NLog;
using System;
using System.Collections.Generic;
using System.Text;

using xamarin_lib_harpia.Exceptions;
using xamarin_lib_harpia.Models.Entities;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin_lib_harpia.Models.Services
{
    public class TextService
    {
        private IPrinterConnection Connection;
        private readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        public TextService(IPrinterConnection connection)
        {
            Connection = connection;
        }

        /// <summary>
        /// Try to start a connection with the printer, check whether it was successful or not and 
        /// if was sucessful return the bytecode reponse from the PrintText method
        /// </summary>
        public bool Execute(Text text)
        {
            var response = Connection.PrintText(text);
            return response;
        }
    }
}
