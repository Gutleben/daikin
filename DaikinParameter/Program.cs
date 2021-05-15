using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace DaikinParameter
{
    class Program
    {
      

        static void Main(string[] args)
        {
            Console.WriteLine("Start Analysis");

            DaikinClass dc = new DaikinClass();
            dc.AnalyisController();
        }
    }
}
