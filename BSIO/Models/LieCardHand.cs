using BSIO.Interfaces;
using BSIO.Helpers;

namespace BSIO.Models
{
	public class LieCardHand : ICardHand
	{
		public List<Card> Cards { get; set; }

		string ICardHand.DeclaredHand { get => playerDeclaredHand; }

		private string playerDeclaredHand;

		public LieCardHand(List<Card> cards, string playerDeclaredHand)
		{
			Cards = cards;
			this.playerDeclaredHand = playerDeclaredHand;
		}

		public LieCardHand(List<Card> cards, string playerDeclaredRank, int numberOfCards)
		{
			Cards = cards;
			this.playerDeclaredHand = $"{numberOfCards} {playerDeclaredRank}";
		}
	}
}
