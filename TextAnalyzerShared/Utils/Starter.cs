using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using TextAnalyzerShared.Core;

namespace TextAnalyzerShared
{
    namespace Utils
    {
        static class Starter
        {
            public static Type[] GetAllMetrics()
            {
                return
                  Assembly.GetExecutingAssembly().GetTypes()
                    .Where(m => m.GetInterfaces().Contains(typeof(ITextMetric)) && !m.IsInterface && !m.IsAbstract)
                    .ToArray();
            }

            public static List<TextMetricResult> RunAnalyzer(StringBuilder sourceText)
            {
                ITextMetric CurrentMetric;
                List<TextMetricResult> PassedMetrics = new List<TextMetricResult>();

                foreach (Type metric in Starter.GetAllMetrics())
                {
                    CurrentMetric = Activator.CreateInstance(metric) as ITextMetric;
                    PassedMetrics.Add(CurrentMetric.Analyze(sourceText));
                }

                return PassedMetrics;
            }
        }
    }
}
