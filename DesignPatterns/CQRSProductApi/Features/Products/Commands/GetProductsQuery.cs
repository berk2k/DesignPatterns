// GetProductsQuery.cs
using CQRSProductApi.Models;
using MediatR;

namespace CQRSProductApi.Features.Products.Queries;

public class GetProductsQuery : IRequest<List<Product>> { }
