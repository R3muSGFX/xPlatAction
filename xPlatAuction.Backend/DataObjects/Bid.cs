using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Azure.Mobile.Server;
using xPlatAuction.Backend.Models;

namespace xPlatAuction.Backend.DataObjects
{
	public class Bid : EntityData
	{
		public double BidAmount { get; set; }

		public string Bidder { get; set; }

		// EF
		[Column("AuctionItem_Id")]
		public string AuctionItemId { get; set; }

		[ForeignKey("AuctionItemId")]
		public virtual AuctionItemDBEntity AuctionItem { get; set; }
	}
}