using System;
using System.Collections.Generic;
using XGame.Domain.Arguments.Base;
using XGame.Domain.Arguments.Jogo;
using XGame.Domain.Interfaces.Services.Base;

namespace XGame.Domain.Interfaces.Services
{
    public interface IServiceJogo : IServiceBase
    {
        IEnumerable<JogoResponse> ListarJogo();

        AdicionarJogoResponse AdicionarJogo(AdicionarJogoRequest request);

        ResponseBase AlterarJogo(AlterarJogoRequest request);

        ResponseBase ExcluirJogo(Guid id);



    }
}
