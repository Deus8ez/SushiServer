using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SushiApi.Data;
using SushiApi.Models;
using SushiApi.Models.ViewModels;

namespace SushiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : Controller
    {
        private readonly SushiContext _context;

        public MainController(SushiContext context)
        {
            _context = context;
        }

        // GET: Main
        [HttpGet]
        public async Task<ActionResult<SushiViewModel>> Index()
        {
            var sushis = await _context.Sushis.ToListAsync();
            var sets = await _context.Sets.ToListAsync();

            return new SushiViewModel
            {
                Sets = sets,
                Sushis = sushis
            };
        }

        [HttpPost]
        public async Task PlaceOrder(OrderViewModel orderData)
        {
            _context.Customers.Add(orderData.Customer);

            var neworder = new Order
            {
                CustomerID = orderData.Customer.ID,
                OrderPlaced = orderData.OrderPlaced,
                CustomerPayment = orderData.Payment
            };

            _context.Orders.Add(neworder);

            foreach (SetViewModel setView in orderData.Sets)
            {
                if (setView.Set.Custom == true)
                {
                    _context.Sets.Add(setView.Set);

                    foreach (Sushi sushi in setView.Sushis)
                    {
                        _context.SushiInSets.Add(new SushiInSets
                        {
                            SetID = setView.Set.ID,
                            SushiID = sushi.ID
                        });
                    }
                }
            }

            await _context.SaveChangesAsync();
        }


        [HttpPost]
        [Route("rate")]
        public async Task RateSet(SetRatingViewModel data)
        {
            var set = _context.Sets.Find(data.SetID);

            if (set == null)
            {
                return;
            }

            set.Rating = data.Rating;

            await _context.SaveChangesAsync();
        }
    }
}
