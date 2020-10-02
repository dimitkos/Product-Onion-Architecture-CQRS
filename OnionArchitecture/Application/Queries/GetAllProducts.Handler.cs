using Application.Interfaces;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Queries
{
    public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllProductsHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _context.Products
                .AsNoTracking()
                .ToListAsync();

            if (products == null)
                return null;

            return products;
        }
    }
}
