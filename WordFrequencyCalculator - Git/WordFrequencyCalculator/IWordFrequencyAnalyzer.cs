using System;
using System.Collections.Generic;
using System.Text;

namespace WordFrequencyAnalyzer
{
    public interface IWordFrequencyAnalyzer
    {
        int CalculateHighestFrequency(string text);
        int CalculateFrequencyForWord(string text, string word);
        IEnumerable<IWordFrequency> CalculateMostFrequentNWords(string text, int n);

        void TextReader();
        void WordReader();
        void NumReader();
    }
}
