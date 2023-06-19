using BSIO.Interfaces;

namespace BSIO.Models
{
	public class GameState
	{
		public List<Card> Deck { get; set; }

		public List<ICardHand> Pile { get; set; }

		public GameState() 
		{
			Deck = new List<Card>();
			Pile = new List<ICardHand>();
		}
	}
}
