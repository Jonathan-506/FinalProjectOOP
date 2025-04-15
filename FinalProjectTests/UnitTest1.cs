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

        [Test]
        public void GetValue()
        {
            Card card = new Card("Jack", "Clubs");
            Assert.AreEqual(10, Tools.GetValue(card));
        }
    }
}