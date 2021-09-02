using LinenAndBird.DataAccess;
using LinenAndBird.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LinenAndBird.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        BirdRepository _birdRepository;
        HatRepository _hatRepository;
        OrdersRepository _ordersRepository;

        public OrdersController()
        {
            _birdRepository = new BirdRepository();
            _hatRepository = new HatRepository();
            _ordersRepository = new OrdersRepository();
        }
        [HttpPost]
        public IActionResult CreateOrder(CreateOrder command)
        {
            var birdToOrder = _birdRepository.GetById(command.BirdId);
            var hatToOrder = _hatRepository.GetById(command.HatId);

            if (hatToOrder == null)
            {
                return NotFound("There is no matching hat in the database");
            }

            if (birdToOrder == null)
            {
                return NotFound("There is no matching bird in the database");
            }

            var order = new Order
            {
                Bird = birdToOrder,
                Hat = hatToOrder,
                Price = command.Price
            };

            _ordersRepository.Add(order);

            return Created($"/api/orders/{order.Id}", order);
        }
    }
}
