using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Microsoft.Azure.Mobile.Server.Tables;
using xPlatAuction.Backend.DataObjects;

namespace xPlatAuction.Backend.Models
{
	public class MobileServiceContext : DbContext
	{
		private const string connectionStringName = "Name=MS_TableConnectionString";

		public MobileServiceContext() : base(connectionStringName)
		{
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Add(
				new AttributeToColumnAnnotationConvention<TableColumnAttribute, string>(
					"ServiceTableColumn", (property, attributes) => attributes.Single().ColumnType.ToString()));
		}

		public DbSet<Auction> Auctions { get; set; }

		public DbSet<Bid> Bids { get; set; }

		public DbSet<AuctionItem> AuctionItems { get; set; }
	}
}