// Created by Owen
// Adapted by Aaron & GAD170 class

using System.Collections.Generic;
using System;
using UnityEngine;

namespace GAD170
{
    //declaring the card suits
    enum CardSuit { Clubs, Spades, Hearts, Diamonds }

    public class Deck : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private Card cardPrefab;

        [Header("Collections")]
        [SerializeField] private List<Card> deck;
        private string[] values = new string[13] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", 
        "10", "Jack", "Queen", "King" };

        void Start()
        {
            //reads through each suit declared in the CardSuit enum...
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                //...and for each one reads through each value in the Card list...
                foreach (string value in values)
                {
                    //...creating a new card from the Card prefab game object...
                    Card _newCard = Instantiate(cardPrefab, transform);
                    //...assigning each new card a value, suit and name so we can easily read it 
                    //in the hierarchy...
                    _newCard.value = value;
                    _newCard.suit = suit.ToString();
                    _newCard.name = value + " of " + suit;
                    //...before adding the new card to the deck list
                    deck.Add(_newCard);
                }
            }
        }
    }
}