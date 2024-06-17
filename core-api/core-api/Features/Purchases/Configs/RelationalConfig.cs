using core_api.Features.Purchases.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace core_api.Features.Purchases.Configs
{
    public class RelationalConfig : IEntityTypeConfiguration<RelationalTransactionCreditCard>
    {
        public void Configure(EntityTypeBuilder<RelationalTransactionCreditCard> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
