using System.Threading.Tasks;
using AutoMapper;
using BurgerMarket.Application.Commands.Burgers;
using BurgerMarket.Application.Queries.Burgers.Get;
using BurgerMarket.Application.Queries.Burgers.GetAll;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMarket.WebUI.Controllers.Burgers.v1
{
    [Route("api/v1/[controller]")]
    public class BurgersController : BaseController
    {
        private readonly IMapper _mapper;
        
        public BurgersController(IMapper mapper)
        {
            _mapper = mapper;
        }
        
        [HttpPost]
        public async Task<ActionResult<int>> Create([FromBody] CreateBurgerDto createModel)
        {
            var command =_mapper.Map<CreateBurgerCommand>(createModel);
            var productId = await Mediator.Send(command);

            return Ok(productId);
        }
        
        [HttpGet]
        public async Task<ActionResult<BurgersListViewModel>> GetAll()
        {
            return Ok(await Mediator.Send(new GetAllBurgersQuery()));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BurgerViewModel>> Get(int id)
        {
            return Ok(await Mediator.Send(new GetBurgerQuery { BurgerId = id }));
        }
    }
}