using System.Collections.Generic;

namespace BurgerMarket.Application.Queries.Burgers.GetAll
{
    public class BurgersListViewModel
    {
        public IEnumerable<BurgerDto> Products { get; set; }

        public bool CreateEnabled { get; set; }
    }
}
