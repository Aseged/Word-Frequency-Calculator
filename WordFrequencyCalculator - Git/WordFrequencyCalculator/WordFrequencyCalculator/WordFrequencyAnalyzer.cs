using System;
using System.Collections.Generic;
using System.Linq;

namespace WordFrequencyAnalyzer
{
    public class WordFrequencyAnalyzer : IWordFrequencyAnalyzer, IWordFrequency
    {
        public string _word;
        public int _frequency;
        public string Word { get => _word; set => _word = value; }

        public int Frequency { get => _frequency; set => _frequency = value; }

        /// <summary>
        ///  calculate how many times a given word appears
        /// </summary>
        /// <param name="text"></param>
        /// <param name="word"></param>
        /// <returns>int</returns>
        public int CalculateFrequencyForWord(string text, string word)
        {
            List<string> wordList = SplitSentence(text);
            List<int> wordFrequency = new List<int>();
            int HighestFrequency = 0;

            foreach (var wordInTheList in wordList.Distinct())
            {
                if (wordInTheList == word.ToLower())
                {
                    for (var i = 0; i < wordList.Count; i++)
                    {
                        if (word == wordList[i]) { HighestFrequency++; }
                    }
                    wordFrequency.Add(HighestFrequency);
                    HighestFrequency = 0;
                }

            }
                Console.WriteLine("The word " + word + " appears " + wordFrequency.Max() + " times.");
            return wordFrequency.Max();
        
        }
        /// <summary>
        ///  calculate which word/s appears the most
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public int CalculateHighestFrequency(string text)
        {
            List<string> wordList = SplitSentence(text);
            List<int> wordFrequency = new List<int>();
            int HighestFrequency = 0;
            foreach (var word in wordList.Distinct())
            {
                for (var i=0; i<wordList.Count; i++)
                {
                    if (word == wordList[i]) { HighestFrequency++; }
                }
                wordFrequency.Add(HighestFrequency);
                HighestFrequency = 0;
            }
            Console.WriteLine("The highest frequency is" + " " + wordFrequency.Max());
            return wordFrequency.Max();

        }
        /// <summary>
        /// Get given n number of words that have the highest frequency
        /// </summary>
        /// <param name="text"></param>
        /// <param name="n"></param>
        /// <returns>List of strings and frequency n</returns>
        public IEnumerable<IWordFrequency> CalculateMostFrequentNWords(string text, int n)
        {

            List<IWordFrequency> resultList = new List<IWordFrequency>();
            List<string> wordList = SplitSentence(text);
            List<string> wordListToBeReturned = new List<string>();
            List<int> wordFrequency = new List<int>();

            int HighestFrequency = 0;
            var emunerator = wordList.GetEnumerator();

            while (emunerator.MoveNext())
            {
                for (var i = 0; i < wordList.Count; i++)
                {
                    if (emunerator.Current == wordList[i]) 
                    {
                        wordListToBeReturned.Add(emunerator.Current);
                        HighestFrequency++; 
                    }
                }
                wordFrequency.Add(HighestFrequency);
                HighestFrequency = 0;
            }
            IEnumerable<string> DistinctWord = wordList.Distinct().Take(n);
            IEnumerable<int> DistincFrequency = wordFrequency.Take(n);

            foreach (string word in DistinctWord)
            {
                Console.WriteLine(word);
            }
            foreach (int frq in DistincFrequency)
            {
                Console.WriteLine(frq);
            }
            return resultList;
        }
        /// <summary>
        /// Read user input and pass it to the spliter
        /// </summary>
        public void TextReader()
        {
            Console.WriteLine("Enter a sentence.");
            var text = Console.ReadLine();
            if (text != "")
            {
                CalculateHighestFrequency(text);
            }
            else
            {
                Console.WriteLine("You must enter a value.");
                TextReader();
            }


        }
        /// <summary>
        /// read word to be searched
        /// </summary>
        public void WordReader()
        {
            Console.WriteLine("Enter a sentence.");
            var text = Console.ReadLine();
            Console.WriteLine("Enter word to be searched.");
            _word = Console.ReadLine();
            if (_word != "" && text != "")
            {
                CalculateFrequencyForWord(text, _word);
            }
            else
            {
                Console.WriteLine("You must enter a value.");
                WordReader();
            }

        }
        /// <summary>
        /// read num representing how many word to display
        /// </summary>
        public void NumReader()
        {
            Console.WriteLine("Enter a sentence.");
            var text = Console.ReadLine();
            Console.WriteLine("Enter number of words to display.");
            _frequency = int.Parse(Console.ReadLine());
            if (_frequency != 0 && text != "")
            {
                CalculateMostFrequentNWords(text, _frequency);
            }
            else
            {
                Console.WriteLine("You must enter a value.");
                NumReader();
            }
        }
        /// <summary>
        /// Get a sentence and splite it into word list
        /// </summary>
        /// <param name="text"></param>
        /// <returns>List of words</returns>
        public static List<string> SplitSentence(string text)
        {
            var wordList = new List<string>();
            char[] separator = {' '};
            string[] NWord = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in NWord)
            {
                wordList.Add(word.ToLower());
            }

            return wordList;
        }

    }
}
