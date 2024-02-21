using AutoMapper;
using CQRSMediator.Domain.Entitiy;
using CQRSMediator.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSMediator.Application.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandHadler : IRequestHandler<UpdateProductCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        public UpdateProductCommandHadler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var updateProductEntity = new Product() { Id = request.Id, Description = request.Description, Name = request.Name};   
            return await _productRepository.UpdateProductsAsync(request.Id, updateProductEntity);
        }
    }
}
