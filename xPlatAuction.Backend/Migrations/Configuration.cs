using System.Data.Entity.Migrations;
using Microsoft.Azure.Mobile.Server.Tables;
using xPlatAuction.Backend.Models;

namespace xPlatAuction.Backend.Migrations
{
	internal sealed class Configuration : DbMigrationsConfiguration<MobileServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "xPlatAuction.Backend.Models.MobileServiceContext";
			SetSqlGenerator("System.Data.SqlClient", new EntityTableSqlGenerator());
        }

        protected override void Seed(MobileServiceContext context)
        {
            
        }
    }
}