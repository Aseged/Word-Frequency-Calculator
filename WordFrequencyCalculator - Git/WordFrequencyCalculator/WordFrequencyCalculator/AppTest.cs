using NUnit.Framework;


namespace WordFrequencyAnalyzer
{
    [TestFixture]
    class AppTest
    {
        string textValue_Pass;
        string wordValue_Pass;
        int returnWordNum_Pass;

        [SetUp]
        public void TestInit()
        {

            textValue_Pass = "The sun shines over the lake";
            wordValue_Pass = "the";
            returnWordNum_Pass = 3;

        }
        [Test]
        [Category("pass")]
        public void CalculateFrequencyForWordPass()
        {
            var wordFrequencyAnalyzer = new WordFrequencyAnalyzer();
            var result = wordFrequencyAnalyzer.CalculateFrequencyForWord(textValue_Pass, wordValue_Pass);
            Assert.AreEqual(2, result);

        }

        [Test]
        [Category("pass")]
        public void CalculateHighestFrequencyPass()
        {
            var wordFrequencyAnalyzer = new WordFrequencyAnalyzer();
            var result = wordFrequencyAnalyzer.CalculateHighestFrequency(textValue_Pass);
            Assert.AreEqual(2, result);
        }

        [Test]
        [Category("pass")]
        public void CalculateMostFrequentNWordsPass()
        {
            var wordFrequencyAnalyzer = new WordFrequencyAnalyzer();
            var result = wordFrequencyAnalyzer.CalculateMostFrequentNWords(textValue_Pass, returnWordNum_Pass);
            Assert.AreEqual(1, result);
        }
    }
}
