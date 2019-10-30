using System;
using System.Collections.Generic;
using System.Text;

namespace WordFrequencyAnalyzer
{

    public class WordAnalyzer : IWordAnalyzer
    {
        IWordFrequencyAnalyzer _wordFrequencyAnalyzer;
        /// <summary>
        /// constructor .. create new instances of required objects (dependency inversion compliance)
        /// </summary>
        /// <param name="wordFrequencyAnalyzer"></param>
        public WordAnalyzer(IWordFrequencyAnalyzer wordFrequencyAnalyzer)
        {
            _wordFrequencyAnalyzer = wordFrequencyAnalyzer;
        }

        public void Start()
        {
            _wordFrequencyAnalyzer.TextReader();
            _wordFrequencyAnalyzer.WordReader();
            _wordFrequencyAnalyzer.NumReader();

        }
    }
}
