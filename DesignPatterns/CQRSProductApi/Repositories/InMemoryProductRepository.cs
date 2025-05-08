// InMemoryProductRepository.cs
using CQRSProductApi.Models;

namespace CQRSProductApi.Repositories;

public class InMemoryProductRepository : IProductRepository
{
    private readonly List<Product> _products = new();

    public void Add(Product product)
    {
        _products.Add(product);
    }

    public List<Product> GetAll()
    {
        return _products;
    }
}
