using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeKatas.Tests
{
    [TestFixture]
    public class MostFrequentlyUsedWordsTests
    {
        [Test]
        public void TestMostFrequentlyUsedWords()
        {
            Assert.That(MostFrequentlyUsedWords.Top3("a a a  b  c c  d d d d  e e e e e"), Is.EqualTo(new List<string> { "e", "d", "a" }));
            Assert.That(MostFrequentlyUsedWords.Top3("e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e"), Is.EqualTo(new List<string> { "e", "ddd", "aa" }));
            Assert.That(MostFrequentlyUsedWords.Top3("  //wont won't won't "), Is.EqualTo(new List<string> { "won't", "wont" }));
            Assert.That(MostFrequentlyUsedWords.Top3("  , e   .. "), Is.EqualTo(new List<string> { "e" }));
            Assert.That(MostFrequentlyUsedWords.Top3("  ...  "), Is.EqualTo(new List<string> { }));
            Assert.That(MostFrequentlyUsedWords.Top3("  '  "), Is.EqualTo(new List<string> { }));
            Assert.That(MostFrequentlyUsedWords.Top3("  '''  "), Is.EqualTo(new List<string> { }));
            Assert.That(MostFrequentlyUsedWords.Top3(
                string.Join("\n", new string[]{"In a village of La Mancha, the name of which I have no desire to call to",
                  "mind, there lived not long since one of those gentlemen that keep a lance",
                  "in the lance-rack, an old buckler, a lean hack, and a greyhound for",
                  "coursing. An olla of rather more beef than mutton, a salad on most",
                  "nights, scraps on Saturdays, lentils on Fridays, and a pigeon or so extra",
                  "on Sundays, made away with three-quarters of his income." })), Is.EqualTo(new List<string> { "a", "of", "on" }));
        }

    }
}
