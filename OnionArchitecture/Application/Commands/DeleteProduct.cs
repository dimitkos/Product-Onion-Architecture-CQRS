using MediatR;

namespace Application.Commands
{
    public class DeleteProduct : IRequest<int>
    {
        public int ProductId { get; private set; }

        public DeleteProduct(int productId)
        {
            ProductId = productId;
        }
    }
}
