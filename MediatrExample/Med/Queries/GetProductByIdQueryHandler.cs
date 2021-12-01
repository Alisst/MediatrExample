using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MediatrExample.Med.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
    {
        public Task<GetProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            //Get product from repository
            var requestId = request.Id;
            return Task.FromResult(new GetProductViewModel
            {
                Id = Guid.NewGuid(),
                Name = "Book"
            });
        }
    }
}
