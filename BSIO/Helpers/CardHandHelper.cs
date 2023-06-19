using BSIO.Models;
using BSIO.Interfaces;
using System.Text;

namespace BSIO.Helpers
{
	public static class CardHandHelper
	{

		public static string HandContentsDeclaration(this List<Card> cards)
		{
			if (cards is null || cards.Count == 0)
				return "None";

			// Determine if all cards equal in rank
			bool validHand = true;
			for (int i = 1; i < cards.Count; i++)
			{
				validHand = cards[0].Rank.Equals(cards[i].Rank);
			}

			// If so,
			if (validHand)
				// Return number of cards plus rank
				return $"{cards.Count} {cards[0].Rank}s";
			// If not,
			else 
			{
				// Return each card csv'd
				StringBuilder sb = new StringBuilder();
				for (int i = 0; i < cards.Count; i++)
				{
					sb.Append("A");

					char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

					if (vowels.Contains(cards[i].Rank[0]))
						sb.Append("n ");
					else
						sb.Append(" ");

					sb.Append($"{cards[i].Rank} of {cards[i].Suit}");
					if (i == cards.Count - 1)
						sb.Append('.');
					else
						sb.Append(", ");
				}

				return sb.ToString();
			}
		}
		public static string HandContentsDeclaration(this ICardHand cardHand)
		{
			return HandContentsDeclaration(cardHand.Cards);
		}

		public static int CardsInPile(this List<ICardHand>? pile)
		{
			int total = 0;

			if (pile is not null)
			{
				foreach (var hand in pile)
				{
					total += hand.Cards.Count;
				}
			}

			return total;
		}
	}
}
