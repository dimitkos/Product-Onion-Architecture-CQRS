using Application.Interfaces;
using Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class AddProductHandler : IRequestHandler<AddProduct, int>
    {
        private readonly IApplicationDbContext _context;

        public AddProductHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(AddProduct request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name = request.Name,
                Barcode = request.Barcode,
                Description = request.Description,
                Rate = request.Rate
            };

            var result = _context.Products.Add(product);
            await _context.SaveChanges();

            return product.Id;
        }
    }
}
