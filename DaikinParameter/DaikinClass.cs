using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DaikinParameter
{


    class DaikinClass
    {
        public List<string> LastCommands { get; set; }

        public Dictionary<string, List<string>> Parameter{get;set;}

        public string Url { get; set; }
        
        public DaikinClass()
        {
            Url = "http://10.13.3.72/aircon/get_control_info";
            LastCommands = new List<string>();
            Parameter = new Dictionary<string, List<string>>();
        }

        public void AnalyisController()
        {
            while (true) { 
                GetControlInfo();
                Thread.Sleep(500);
            }
        }

        private void GetControlInfo()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(Url);
            req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)req.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                string command = reader.ReadToEnd();

                var commandExists = LastCommands.Any(c => c == command);
                if (!commandExists) { 
                    LastCommands.Add(command);
                    Console.WriteLine(command);
                }


                var parameter = command.Split(',');
                foreach(var para in parameter) { 
                    var parameterKey = para.Split('=')[0];
                    var parameterValue = para.Split('=')[1];

                    if(!Parameter.Keys.Contains(parameterKey))
                        Parameter.Add(parameterKey, new List<string>());

                    var valueList = Parameter[parameterKey];
                    if(valueList.Count == 0 || valueList.Last() != parameterValue) { 
                        Parameter[parameterKey].Add(parameterValue);
                        Console.WriteLine(para);
                    }
                    
                }
            }
        }
    }
}
