using CQRSProductApi.Models;
namespace CQRSProductApi.Repositories;



public interface IProductRepository
{
    void Add(Product product);
    List<Product> GetAll();
}
