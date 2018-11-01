using System;
using Microsoft.Azure.Mobile.Server;

namespace xPlatAuction.Backend.DataObjects
{
	public class Auction : EntityData
	{
		public string Name { get; set; }

		public string Description { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime StopDate { get; set; }			
	}
}