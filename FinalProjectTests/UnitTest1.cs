using FinalProjectOOP;

namespace FinalProjectTests
{
    public class Tests
    {
        public Deck deck { get; set; } 

        [SetUp]
        public void Setup()
        {
            deck = new Deck();
        }

        [Test]
        public void CreateDeckTest()
        {
            deck.CreateDeck();
            Assert.AreEqual(52, deck.Cards.Count);
        }

    }
}