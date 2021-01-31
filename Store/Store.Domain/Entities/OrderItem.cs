using Flunt.Validations;

namespace Store.Domain.Entities
{
    public class OrderItem : Entity
    {
        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Price = Product != null ? Product.Price : 0;
            Quantity = quantity;

            Validate();
        }

        public Product Product { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNull(Product, "Product", "Produto inválido")
                .IsGreaterThan(Quantity, 0, "Quantity", "A quantidade deve ser maior que zero."));
        }

        public decimal Total() =>
            Price * Quantity;
    }
}