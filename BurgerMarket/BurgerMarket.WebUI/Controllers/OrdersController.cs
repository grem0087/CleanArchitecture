using System.Collections.Generic;
using System.Threading.Tasks;
using BurgerMarket.Application.Queries.Orders.GetDetail;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMarket.WebUI.Controllers
{
    public class OrdersController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDetailModel>>> GetCategoryPreview([FromQuery] GetOrderDetailQuery query)
        {
            return Ok(await Mediator.Send(query));
        }
    }
}
