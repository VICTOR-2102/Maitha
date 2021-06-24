
using Domínio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Config
{
   public class AgenciaConfig : IEntityTypeConfiguration<Agencia>
    {
        public void Configure(EntityTypeBuilder<Agencia> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Endereco)
                .IsRequired();

            builder.Property(a => a.Bairro)
               .IsRequired();

            builder.Property(a => a.Cidade)
               .IsRequired();

            builder.Property(a => a.Estado)
               .IsRequired();

            builder.Property(a => a.Cep)
              .IsRequired();

            builder.HasMany(a => a.Contas)
               .WithOne(a => a.Agencia);






        }

    }
}
