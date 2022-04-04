using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Taller2
{
    public class Tests
    {

        Deck Deck1;
        Player playerTest =new Player();
        List<Card> l_cards = new List<Card>();
        

       
        [TearDown]
        public void Reset()
        {

        }


        [Test]
        public void DeckLimitadoPorCostPoints()
        {
            Deck1 = null;
            Deck1 = new Deck(l_cards, 45);
            uint valor_inicial = Deck1.CostPoints;
            Character michi_warrior = playerTest.CrearCharacter();

            playerTest.AgregarCartaAlDeck(Deck1, michi_warrior);

            //Valor inicial debe ser mayor al valos de los costpoints despues de agregar la carta
            Assert.IsTrue(valor_inicial > Deck1.CostPoints);

           
                
        }
    }
}