using DoiSoat.Core.Entities;

namespace DoiSoat.Core.Interfaces.Infrastructure
{
    public interface ICartRepository
    {
        IEnumerable<Cart> GetAll();
        IEnumerable<Cart> GetByCode(int code);// dondi = 1, don cod gui = 2, donhoan = 3
        bool UploadMutipleCart(IEnumerable<Cart> CartList);
        bool DeleteMutipleCart(IEnumerable<Cart> CartList);
        bool DeleteCart(Cart cart);
    }
}
