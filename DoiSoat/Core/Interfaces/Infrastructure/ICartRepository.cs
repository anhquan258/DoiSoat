using DoiSoat.Core.Entities;

namespace DoiSoat.Core.Interfaces.Infrastructure
{
    public interface ICartRepository
    {
        IEnumerable<Cart> GetAll();
        IEnumerable<Cart> GetByCode(string code);
        bool UploadMutipleCart(IEnumerable<Cart> CartList);
        bool DeleteMutipleCart(IEnumerable<Cart> CartList);
        bool DeleteCart(Cart cart);
    }
}
