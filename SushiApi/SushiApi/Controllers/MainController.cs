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

            List<SetViewModel> setsDetailed = new List<SetViewModel>();

            foreach (Set set in sets)
            {
                setsDetailed.Add(new SetViewModel
                {
                    Set = set,
                    Sushis = (from sushiTable in _context.Sushis
                              join sushiInSetsTable in _context.SushiInSets on sushiTable.ID equals sushiInSetsTable.SushiID
                              where sushiInSetsTable.SetID == set.ID
                              select sushiTable).ToList()
                });
            };

            return new SushiViewModel
            {
                Sets = setsDetailed,
                Sushis = sushis
            };
        }

        [HttpPost]
        public async Task PlaceOrder(OrderViewModel orderData)
        {

            foreach (SetViewModel setView in orderData.Sets)
            {
                if (setView.Set.Custom == true && !_context.Sets.Contains(setView.Set))
                {
                    _context.Sets.Add(setView.Set);

                    await _context.SaveChangesAsync();

                    foreach (Sushi sushi in setView.Sushis)
                    {
                        _context.SushiInSets.Add(new SushiInSets
                        {
                            SetID = setView.Set.ID,
                            SushiID = sushi.ID,
                            SushiAmount = sushi.Amount
                        });
                    }
                }
            }

            await _context.SaveChangesAsync();


            _context.Customers.Add(orderData.Customer);

            await _context.SaveChangesAsync();

            var neworder = new Order
            {
                CustomerID = orderData.Customer.ID,
                OrderPlaced = orderData.OrderPlaced,
                CustomerPayment = orderData.Payment
            };

            _context.Orders.Add(neworder);

            await _context.SaveChangesAsync();

            foreach (SetViewModel setView in orderData.Sets)
            {
                _context.SetsInOrders.Add(new SetsInOrders
                {
                    SetID = setView.Set.ID,
                    OrderID = neworder.ID,
                });
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
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

            double avgRating = 0;

            List<SetRatingHistory> SetRatings = _context.SetRatingHistories
                .Where(x => x.SetID == data.SetID)
                .ToList();

            foreach (SetRatingHistory e in SetRatings)
            {
                avgRating += e.Rating;
            }

            set.Rating = (int)Math.Ceiling((avgRating + data.Rating) / (SetRatings.Count + 1));

            _context.SetRatingHistories.Add(
                new SetRatingHistory
                {
                    SetID = data.SetID,
                    Rating = data.Rating
                }
            );

            await _context.SaveChangesAsync();
        }
    }
}
