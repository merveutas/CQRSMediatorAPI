using CQRSMediator.Application.Common.Mappings;
using CQRSMediator.Domain.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSMediator.Application.Products.Queries.GetProducts
{
    public class ProductVm : IMapFrom<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
