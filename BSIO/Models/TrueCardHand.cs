using BSIO.Interfaces;
using BSIO.Helpers;

namespace BSIO.Models
{
	public class TrueCardHand : ICardHand
	{
		public List<Card> Cards { get; set; }
		string ICardHand.DeclaredHand { get => Cards.HandContentsDeclaration(); }

		public TrueCardHand(List<Card> cards)
		{
			Cards = cards;
		}
	}
}
