using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaERP.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaERP.Data
{
    public class VendaItemMap : IEntityTypeConfiguration<VendaItem>
    {
        public void Configure(EntityTypeBuilder<VendaItem> builder)
        {
            builder.Property(x => x.EAN)
                .HasMaxLength(15);
        }
    }
}
