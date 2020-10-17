using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    public interface IEcommerceDbContextDbContextInitializer
    {
        bool EnsureCreated();
        void Migrate();
        Task Seed();
    }
}