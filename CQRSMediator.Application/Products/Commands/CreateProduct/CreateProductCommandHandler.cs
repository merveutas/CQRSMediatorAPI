using AutoMapper;
using CQRSMediator.Application.Products.Queries.GetProducts;
using CQRSMediator.Domain.Entitiy;
using CQRSMediator.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSMediator.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ProductVm>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<ProductVm> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var productEntity = new Product() { Name = request.Name, Description = request.Description };
            var result = await _productRepository.CreateProductAsync(productEntity);
            return _mapper.Map<ProductVm>(result);
        }
    }
}
