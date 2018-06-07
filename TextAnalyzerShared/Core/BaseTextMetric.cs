using System;
using System.Collections.Generic;
using System.Text;

namespace TextAnalyzerShared
{
    namespace Core
    {
        public abstract class BaseTextMetric : ITextMetric
        {
            public abstract string Name { get; }
            public abstract string Measure { get; }

            public string Value { get; private set; }
            public StringBuilder SourceText { get; private set; }
 
            public TextMetricResult Result
            {
                get
                {
                    return new TextMetricResult(Name, Value, Measure);
                }
            }

            public abstract string Calculate();

            public TextMetricResult Analyze(StringBuilder sourceText)
            {
                SourceText = sourceText;
                Value = Calculate();
                return new TextMetricResult(Name, Value, Measure);
            }
        }

        public struct TextMetricResult
        {
            public string Name;
            public string Value;
            public string Measure;

            public TextMetricResult(string Name, string Value, string Measure)
            {
                this.Name = Name;
                this.Value = Value;
                this.Measure = Measure;
            }

            public override string ToString()
            {
                return String.Format("Metric: {0} = {1} {2}", Name, Value, Measure);
            }
        }
    }
}
