using DoiSoat.Core.Entities;

namespace DoiSoat.Core.Interfaces.Services
{
    public interface ICartService
    {
        IEnumerable<Cart> GetCartsDone();
        IEnumerable<Cart> GetCarts123();
        IEnumerable<Cart> GetCarts12k3();
        IEnumerable<Cart> GetCartsFail();
    }
}
