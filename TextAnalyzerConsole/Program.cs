using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using TextAnalyzerShared.Core;
using TextAnalyzerShared.Utils;

namespace TextAnalyzerConsole
{

    class Program
    {
        static void Main(string[] args)
        {
            int fileParam = Array.FindIndex(args, s => s.StartsWith("/f:", StringComparison.OrdinalIgnoreCase));

            if (args.Contains("/h"))
            {
                Console.WriteLine("Active metrics:");
                foreach (Type metric in Starter.GetAllMetrics())
                {
                    Console.WriteLine(metric.FullName);
                }
            }
            else if (fileParam>-1)
            {
                string fileName = Regex.Replace(args[fileParam], "^/f:", "");
                Console.WriteLine("Analyzing file: {0}", fileName);

                StreamReader reader = new StreamReader(fileName);
                StringBuilder sourceText = new StringBuilder(reader.ReadToEnd());

                foreach (var metricResult in Starter.RunAnalyzer(sourceText))
                {
                    Console.WriteLine(metricResult.ToString());
                }
            }
            else
            {
                Console.WriteLine("No known parameters provided.");
            }
            Console.ReadLine();
        }
    }
}
