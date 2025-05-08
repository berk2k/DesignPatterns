// GetProductsHandler.cs
using CQRSProductApi.Repositories;
using CQRSProductApi.Models;
using MediatR;

namespace CQRSProductApi.Features.Products.Queries;

public class GetProductsHandler : IRequestHandler<GetProductsQuery, List<Product>>
{
    private readonly IProductRepository _repo;

    public GetProductsHandler(IProductRepository repo)
    {
        _repo = repo;
    }

    public Task<List<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_repo.GetAll());
    }
}
