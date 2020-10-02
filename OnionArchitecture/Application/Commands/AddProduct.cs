using MediatR;

namespace Application.Commands
{
    public class AddProduct : IRequest<int>
    {
        public string Name { get; private set; }
        public string Barcode { get; private set; }
        public string Description { get; private set; }
        public decimal Rate { get; private set; }

        public AddProduct(string name, string barcode, string description, decimal rate)
        {
            Name = name;
            Barcode = barcode;
            Description = description;
            Rate = rate;
        }
    }
}
