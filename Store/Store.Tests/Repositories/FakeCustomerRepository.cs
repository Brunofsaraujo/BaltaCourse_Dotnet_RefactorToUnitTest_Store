using Store.Domain.Entities;
using Store.Domain.Repositories;

namespace Store.Tests.Repositories
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        public Customer Get(string document)
        {
            if (document == "123456789")
                return new Customer(
                    name: "Cliente 1",
                    email: "cliente1@hotmail.com"
                );

            return null;
        }
    }
}