using DoiSoat.Core.Entities;
using DoiSoat.Core.Interfaces.Infrastructure;
using DoiSoat.Core.Interfaces.Services;

namespace DoiSoat.Core.Service
{
    public class CartService : ICartService
    {
        ICartRepository _cartRepository;
        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public IEnumerable<Cart> GetCarts123()
        {
            IEnumerable<Cart> listDonDi = _cartRepository.GetByCode(1);
            IEnumerable<Cart> listDonVanChuyenBaoCao = _cartRepository.GetByCode(2);
            IEnumerable<Cart> listDonHoan = _cartRepository.GetByCode(3);

            var commonProducts = (from p1 in listDonDi
                                  from p2 in listDonVanChuyenBaoCao
                                  from p3 in listDonHoan
                                  where p1.Code == p2.Code && p2.Code == p3.Code
                                  && p1.Price == p2.Price + p3.Price
                                  select p1).ToList();
            return commonProducts;
            throw new NotImplementedException();
        }

        public IEnumerable<Cart> GetCarts12k3()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cart> GetCartsDone()
        {
            IEnumerable<Cart> listDonDi = _cartRepository.GetByCode(1);
            IEnumerable<Cart> listDonVanChuyenBaoCao = _cartRepository.GetByCode(2);
            var commonProducts = listDonVanChuyenBaoCao
            .Join(listDonDi,
                  p1 => new { p1.Code, p1.Price },
                  p2 => new { p2.Code, p2.Price },
                  (p1, p2) => p1)
            .ToList();
            return commonProducts;
            throw new NotImplementedException();
        }

        public IEnumerable<Cart> GetCartsFail()
        {
            throw new NotImplementedException();
        }
    }
}
