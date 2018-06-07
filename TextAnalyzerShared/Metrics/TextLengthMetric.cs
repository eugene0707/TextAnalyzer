using System;
using System.Collections.Generic;
using System.Text;
using TextAnalyzerShared.Core;

namespace TextAnalyzerShared
{
    namespace Metrics
    {
        class TextLengthMetric : BaseTextMetric
        {
            public override string Name => "Length of text";
            public override string Measure => "chars";

            public override string Calculate()
            {
                return SourceText.Length.ToString();
            }

        }
    }
}
