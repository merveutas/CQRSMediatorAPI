using CQRSMediator.Application.Products.Queries.GetProducts;
using CQRSMediator.Domain.Entitiy;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSMediator.Application.Products.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<ProductVm>    
    {
        public int ProductId { get; set; }

    }
}
