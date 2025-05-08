// CreateProductHandler.cs
using MediatR;
using CQRSProductApi.Repositories;
using CQRSProductApi.Models;

namespace CQRSProductApi.Features.Products.Commands;

public class CreateProductHandler : IRequestHandler<CreateProductCommand, Guid>
{
    private readonly IProductRepository _repo;

    public CreateProductHandler(IProductRepository repo)
    {
        _repo = repo;
    }

    public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Price = request.Price
        };

        _repo.Add(product);
        return Task.FromResult(product.Id);
    }
}
