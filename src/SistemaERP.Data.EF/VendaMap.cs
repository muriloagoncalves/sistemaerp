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
    public class VendaMap : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder
                .Property(x => x.ChaveDeAcesso)
                .HasMaxLength(44)
                .HasColumnName("chave_de_acesso");

            builder
                .HasMany(x => x.Itens)
                .WithOne(i => i.Venda)
                .HasForeignKey(x => x.IdVenda)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
