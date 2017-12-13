using System;
using XGame.Domain.Entities;

namespace XGame.Domain.Arguments.Jogo
{
    public class JogoResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Produtora { get; set; }

        public string Distribuidora { get; set; }

        public string Genero { get; set; }

        public string Site { get; set; }

        public static explicit operator JogoResponse(Entities.Jogo entidade)
        {
            return new JogoResponse() {
                Descricao = entidade.Descricao,
                Distribuidora = entidade.Distribuidora,
                Genero = entidade.Genero,
                Id = entidade.Id,
                 Nome = entidade.Nome,
                 Produtora = entidade.Produtora,
                 Site = entidade.Site
            };
        }
    }
}
