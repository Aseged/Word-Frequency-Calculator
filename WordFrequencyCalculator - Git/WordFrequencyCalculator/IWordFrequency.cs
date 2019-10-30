using System;
using System.Collections.Generic;
using System.Text;

namespace WordFrequencyAnalyzer
{
    public interface IWordFrequency
    {
        string Word { get; }
        int Frequency { get; }

    }
}
