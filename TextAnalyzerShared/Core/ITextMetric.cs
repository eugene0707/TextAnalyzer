using System;
using System.Collections.Generic;
using System.Text;

namespace TextAnalyzerShared
{
    namespace Core
    {
        interface ITextMetric
        {
            TextMetricResult Analyze(StringBuilder sourceText);

            TextMetricResult Result {get;}

        }
    }
}
