using System;
using static System.Console;
using static Botopia.Utility;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botopia
{
    class CardsANDdeck
    {
        
        
            public string Name;
        public int Value;
        public Suit Suits;

        public CardsANDdeck(string _name, Suit _suits, int _value)
        {
            Name = _name;
            Suits = _suits;
            Value = _value;
        }
        public string GetSuitAndValue()
        {
            switch (Suits)
            {
                case Suit.Clubs:
                    return $"{GetValue()}♣";
                case Suit.Spades:
                    return $"{GetValue()}♠";
                case Suit.Hearts:
                    return $"{GetValue()}♥";
                case Suit.Diamonds:
                    return $"{GetValue()}♦";
                default:
                    return GetValue();
            }
        }
        private string GetValue()
        {
            switch (Value)
            {
                case 1:
                    return "A";
                case 11:
                    return "J";
                case 12:
                    return "Q";
                case 13:
                    return "K";
                default:
                    return Convert.ToString(Value);
            }
        }
        public static void ShowCard(CardsANDdeck card)
        {
            ConsoleColor color = ForegroundColor;
            if (card.Suits == Suit.Diamonds || card.Suits == Suit.Hearts)
            {
                ForegroundColor = ConsoleColor.DarkRed;
            }
            else
            {
                ForegroundColor = ConsoleColor.Black;
            }
            Print(CardImage(card));
            ForegroundColor = color;
        }
        public static void ShowCards(CardsANDdeck cardA, CardsANDdeck cardB) => Print(TwoCardImages(cardA, cardB));

        public static string CardImage(CardsANDdeck card)
        {
            string value = card.GetSuitAndValue() + " ";
            if (card.Value != 10)
                value += " ";

            return $@"
         _____     
        |{value} |
        |     |
        |     |
        |     |
        |___{value}
            ";
        }

        public static string TwoCardImages(CardsANDdeck cardA, CardsANDdeck cardB)
        {//TODO: Change color depending on suit
            string valueA = cardA.Value != 10
                ? cardA.GetSuitAndValue() + " "
                : cardA.GetSuitAndValue();

            string valueB = cardB.Value != 10
                ? cardB.GetSuitAndValue() + " "
                : cardB.GetSuitAndValue();

            return $@"
           1             2
         _____         _____     
        |{valueA}  |       |{valueB}  |
        |     |       |     |
        |     |       |     |
        |     |       |     |
        |__{valueA}|       |__{valueB}|
";
        }

        
            internal enum Suit : byte
        {
            Clubs,
            Spades,
            Diamonds,
            Hearts
        }
        internal class Deck
        {
            public List<CardsANDdeck> cards = new List<CardsANDdeck>();
            public Suit[] Suits = { Suit.Clubs, Suit.Diamonds, Suit.Hearts, Suit.Spades };

            public int CardsInDeck => cards.Count;
            public int NumSuits => Suits.Length;

            //shuffle
            public void Shuffle()
            {
                CardsANDdeck[] shuffled = cards.ToArray().OrderBy(x => RanNum.Next()).ToArray();
                cards = shuffled.ToList();
            }

            //draw
            public CardsANDdeck Draw()
            {
                return cards[RanNum.Next(cards.Count)];
            }

            //show
            public string Show(CardsANDdeck card)
            {
                return card.Name;
            }

            //remove
            public void Remove(CardsANDdeck card)
            {
                cards.Remove(card);
            }

            //constructer
            public Deck(int size, Suit[] suits)
            {
                int set = size / suits.Length;

                for (int i = 1; i <= set; i++)
                {
                    for (int j = 0; j < suits.Length; j++)
                    {
                        switch (i)
                        {
                            case 1:
                                cards.Add(new CardsANDdeck("Ace of " + suits[j], suits[j], i));
                                break;
                            case 11:
                                cards.Add(new CardsANDdeck("Jack of " + suits[j], suits[j], i));
                                break;
                            case 12:
                                cards.Add(new CardsANDdeck("Queen of " + suits[j], suits[j], i));
                                break;
                            case 13:
                                cards.Add(new CardsANDdeck("King of " + suits[j], suits[j], i));
                                break;
                            default:
                                cards.Add(new CardsANDdeck(i + " of " + suits[j], suits[j], i));
                                break;
                        }
                    }
                }
            }

            //show all
            public string ShowAll()
            {
                return "";
            }
        }
        }
    }


