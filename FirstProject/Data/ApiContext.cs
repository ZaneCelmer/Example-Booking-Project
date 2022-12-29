using Microsoft.EntityFrameworkCore;
using ExampleBookingProject.Models;

namespace ExampleBookingProject.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<HotelBooking> Bookings {get; set;}

        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }
    }
}
