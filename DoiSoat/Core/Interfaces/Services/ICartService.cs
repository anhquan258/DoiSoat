using DoiSoat.Core.Entities;

namespace DoiSoat.Core.Interfaces.Services
{
    public interface ICartService
    {
        IEnumerable<Cart> GetCartsDone();
        IEnumerable<Cart> GetCarts
    }
}
