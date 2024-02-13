using CQRSMediator.Application.Products.Queries.GetProducts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSMediator.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<ProductVm>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
