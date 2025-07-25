﻿using Exemplo.Domain.Model;
using Exemplo.Persistence;
using Exemplo.Service.Queries;
using MediatR;

namespace MPS.Exemplo.Service.Handlers.Assinatura
{
    public class ExemploQueryHandler : IRequestHandler<ExemploQuery, ExemploModel>
    {
        private readonly ExemploDbContext _exemploDbContext;
        public ExemploQueryHandler(ExemploDbContext exemploDbContext)
        {
            _exemploDbContext = exemploDbContext;
        }

        public async Task<ExemploModel> Handle(ExemploQuery request, CancellationToken cancellationToken)
        {
            var exemplo = await _exemploDbContext.Exemplo.FindAsync(request.CampoQuery, cancellationToken);

            return exemplo;
        }
    }
}
