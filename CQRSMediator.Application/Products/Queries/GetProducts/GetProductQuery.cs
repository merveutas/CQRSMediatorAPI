using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSMediator.Application.Products.Queries.GetProducts
{
    public class GetProductQuery : IRequest<List<ProductVm>>
    {

    }

    //public record GetProductQuery : IRequest<List<ProductVm>>
    //{

    //}
}
