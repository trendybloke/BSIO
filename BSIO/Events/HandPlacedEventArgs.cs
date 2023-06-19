using BSIO.Interfaces;

namespace BSIO.Events
{
	public class HandPlacedEventArgs : EventArgs
	{
		public readonly ICardHand Hand;

		public HandPlacedEventArgs(ICardHand hand)
		{
			Hand = hand;
		}
	}
}
