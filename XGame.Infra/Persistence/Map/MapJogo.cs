using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using XGame.Domain.Entities;

namespace XGame.Infra.Persistence.Map
{
    public class MapJogo : EntityTypeConfiguration<Jogo>
    {
        public MapJogo()
        {
            ToTable("Jogo");

            Property(p => p.Nome).HasMaxLength(100).IsRequired();
            Property(p => p.Descricao).HasMaxLength(255).IsRequired();
            Property(p => p.Produtora).HasMaxLength(50);
            Property(p => p.Distribuidora).HasMaxLength(50);
            Property(p => p.Genero).HasMaxLength(50);
            Property(p => p.Site).HasMaxLength(200);
        }
    }
}
