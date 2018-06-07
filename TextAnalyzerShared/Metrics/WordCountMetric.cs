using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using TextAnalyzerShared.Core;

namespace TextAnalyzerShared
{
    namespace Metrics
    {
        class WordCountMetric : BaseTextMetric
        {
            public override string Name => "Count of words";
            public override string Measure => "pcs";

            public override string Calculate()
            {
                string pattern = "\\w+";
                Regex regex = new Regex(pattern);

                return regex.Matches(SourceText.ToString()).Count.ToString();
            }

        }
    }
}
