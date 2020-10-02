using Domain.Entities;
using MediatR;

namespace Application.Queries
{
    public class GetProductQuery : IRequest<Product>
    {
        public int ProductId { get; private set; }

        public GetProductQuery(int productId)
        {
            ProductId = productId;
        }
    }
}
