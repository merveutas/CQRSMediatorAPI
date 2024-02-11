using AutoMapper;
using CQRSMediator.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CQRSMediator.Application.Products.Queries.GetProducts
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, List<ProductVm>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<List<ProductVm>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetAllProductsAsync();
            //var productList = products.Select(x => new ProductVm { Name = x.Name, Description = x.Description, Id = x.Id }).ToList();
          
            var productList = _mapper.Map<List<ProductVm>>(products);   
            return productList;
        }
    }
}
