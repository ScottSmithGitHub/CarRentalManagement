using CarRentalManagement.Shared.Domain;

namespace CarRentalManagement.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Make> Makes { get; }
        IGenericRepository<Model> Models { get; }
        IGenericRepository<Vehicle> Vehicles { get; }
        IGenericRepository<Color> Colors { get; }
        IGenericRepository<Booking> Bookings { get; }
        IGenericRepository<Customer> Customers { get; }
    }
}
