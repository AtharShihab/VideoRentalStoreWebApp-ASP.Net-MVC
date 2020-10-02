using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Management;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //POST /api/rentals
        [HttpPost]
        public IHttpActionResult CreateNewRental(NewRentalDto newRentalDto)
        {
            var customer = _context.Customers.Single(
                c => c.Id == newRentalDto.CustomerId
                );


            var movies = _context.Movies.Where(
                m => newRentalDto.MovieIds.Contains(m.Id)
                ).ToList();

            
            foreach(var movie in movies)
            {

                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available");


                var newRental = new Rental
                {
                    CustomerId = customer.Id,
                    MovieId = movie.Id,
                    DateRanted = DateTime.Today
                };

                
                movie.NumberAvailable--;


                _context.Rentals.Add(newRental);
            }

            _context.SaveChanges();

            return Ok();
            
        }
    }
}
