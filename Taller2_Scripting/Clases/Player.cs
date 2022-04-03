using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2_Scripting.Clases
{
    class Player
    {
        


        public Deck AgregarCartaAlDEck (Deck deck,Card card)
        {
            int cantidadCharacter;
            int cantidadEquip;
            int cantidadSupport;

           // foreach ()



            if (deck.CostPoints > 0 && card.CostPoint <= deck.CostPoints)
            {
               
                deck.Lcards.add(card);
                deck.CostPoints -= card.CostPoint; 
            }
            
            return deck;
        }



    }
}
