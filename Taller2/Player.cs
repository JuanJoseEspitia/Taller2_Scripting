﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2
{
    internal class Player
    {

        public Character CrearCharacter1()
        {
            
            Character charac = null;

            Random randomAP = new Random();
            uint rndAP = (uint)randomAP.Next(1,6);
            Random randomRP = new Random();
            uint rndRP = (uint)randomRP.Next(1,6);
            Random randomCP = new Random();
            uint rndCP = (uint)randomCP.Next(1,6);

            

            charac.AttackPoints = rndAP;
            charac.ResistPoints = rndRP;
            charac.CostPoint = rndCP;

            Array valuesAffi = Enum.GetValues(typeof(Character.laffinitys));
            Random randomAffi = new Random();
            Character.laffinitys randomAffinity = (Character.laffinitys)randomAffi.Next(valuesAffi.Length);

            Array valuesRare = Enum.GetValues(typeof(Character.lrarety));
            Random randomRare = new Random();
            Character.lrarety randomRarety = (Character.lrarety)randomRare.Next(valuesRare.Length);


            return charac;
        }
        public Equip CrearEquip()
        {
            Equip equip = null;

            return equip;
        }
         public SupportSkill CrearsupportSkill()
        {
            SupportSkill supportskill = null;

            return supportskill;
        }
        public Deck AgregarCartaAlDeck(Deck deck, Card card)
        {
            int cantidadCharacter = 0;
            int cantidadEquip = 0;
            int cantidadSupport = 0;

            foreach (Card element in deck.Lcards)
            {
                if (element is Character) cantidadCharacter++;
                else if (element is Equip) cantidadEquip++;
                else cantidadSupport++;
            }

            if (card is Character && cantidadCharacter < 5 && deck.CostPoints > 0 && card.CostPoint <= deck.CostPoints)
            {
                deck.Lcards.Add(card);
                deck.CostPoints -= card.CostPoint;
            }
            else if (card is Equip && cantidadEquip < 10 && deck.CostPoints > 0 && card.CostPoint <= deck.CostPoints)
            {
                deck.Lcards.Add(card);
                deck.CostPoints -= card.CostPoint;
            }
            else if (card is SupportSkill && cantidadSupport < 5 && deck.CostPoints > 0 && card.CostPoint <= deck.CostPoints)
            {
                deck.Lcards.Add(card);
                deck.CostPoints -= card.CostPoint;
            }

            return deck;
        }

        public Deck CrearDeck(uint costPoint)
        {
            List<Card> l_cards = new List<Card>();

            Deck deck = new Deck(l_cards, costPoint);

            return deck;

        }

        public Character CrearCharacter()
        {
            List<Equip> l_equips = new List<Equip>();
            Character michi_warrior = new Character("Michi Guerrero", Character.lrarety.UltraRare, 4, 5, 5, l_equips, Character.laffinitys.Knight);
            return michi_warrior;
        }

    }
}
