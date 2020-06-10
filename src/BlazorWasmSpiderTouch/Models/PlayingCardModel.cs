using System;
using System.Text;

namespace BlazorWasmSpiderTouch.Models
{
    public class PlayingCardModel
    {
        private const string CardIds = "A23456789TJQK";
        public int Id { get; set; }
        public int Value { get; set; }
        public Suit Suit { get; set; }
        public string Description { get { return IsFaceDown ? "Back of Card" : CardIds.Substring(Value-1, 1) + " " + Suit.ToString(); } }
        public string ImageUrl
        {
            get
            {
                string key = IsFaceDown ? "2B" : CardIds.Substring(Value - 1, 1) + this.Suit.ToString().Substring(0, 1);
                return "data:image/svg+xml;base64," + Convert.ToBase64String(Encoding.UTF8.GetBytes(PlayingCardDeck.SvgDefinitions[key]));
            }
        }
        public int TableauId { get; set; }
        public int StockId { get; set; }
        public int FoundationId { get; set; }
        public int PileSequence { get; set; }
        public bool IsFaceDown { get; set; }
        public bool IsSelected { get; set; }
    }
}

public enum Suit
{
    Spade,
    Heart,
    Club,
    Diamond
}
