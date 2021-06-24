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
  public  class ContatoConfig : IEntityTypeConfiguration<Contato>
    {

        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.ClienteId)
                .IsRequired();

            builder.Property(c => c.TipoContato)
               .IsRequired();

            builder.Property(c => c.Telefone)
               .IsRequired();

        }
    }
}
