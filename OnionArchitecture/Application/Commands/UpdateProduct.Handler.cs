using Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class UpdateProductHandler : IRequestHandler<UpdateProduct, int>
    {
        private readonly IApplicationDbContext _context;

        public UpdateProductHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateProduct request, CancellationToken cancellationToken)
        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.Id == request.Id);

            if (product == null)
                return default;

            _context.Products.Update(product);
            await _context.SaveChanges();

            return product.Id;
        }
    }
}
