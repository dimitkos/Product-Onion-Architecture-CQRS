using Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Application.Queries
{
    public class GetAllProductsQuery : IRequest<IEnumerable<Product>>
    {

    }
}
