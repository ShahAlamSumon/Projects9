﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
                Application.Run(new WeatherUI()); 
                
           
        }
    }
}
