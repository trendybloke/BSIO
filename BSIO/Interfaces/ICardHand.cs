using BSIO.Helpers;
using BSIO.Models;

namespace BSIO.Interfaces
{
	public interface ICardHand
	{
		public List<Card> Cards { get; set; }
		public string DeclaredHand { get => Cards.HandContentsDeclaration(); }
	}
}
