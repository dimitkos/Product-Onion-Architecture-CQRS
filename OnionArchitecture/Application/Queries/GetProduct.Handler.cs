using Application.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Queries
{
    public class GetProductHandler : IRequestHandler<GetProductQuery, Product>
    {
        private readonly IApplicationDbContext _context;

        public GetProductHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Product> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == request.ProductId);

            if (product == null)
                return null;

            return product;
        }
    }
}
