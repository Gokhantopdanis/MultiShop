using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace MultiShop.Order.Application.Features.Meditor.Commands.OrderingCommands
{
    public class CreateOrderingCommands: IRequest
    {
        public string UserId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
