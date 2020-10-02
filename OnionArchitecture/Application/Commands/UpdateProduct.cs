using MediatR;

namespace Application.Commands
{
    public class UpdateProduct : IRequest<int>
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Barcode { get; private set; }
        public string Description { get; private set; }
        public decimal Rate { get; private set; }

        public UpdateProduct(int id, string name, string barcode, string description, decimal rate)
        {
            Id = id;
            Name = name;
            Barcode = barcode;
            Description = description;
            Rate = rate;
        }
    }
}
