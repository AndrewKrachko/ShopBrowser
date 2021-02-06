using System;
using System.Collections.Generic;

namespace ShopBrowser.Kernel
{
    public class ShopBrowserKernel : IBrowserKernel
    {
        private IBrowserRepository _repository;

        public ShopBrowserKernel(IBrowserRepository repository)
        {
            _repository = repository;
        }

        bool IBrowserKernel.GetShop(int id, IShop shop)
        {
            try
            {
                var result = _repository.GetShop(id, out IShop shopOut);
                shop = shopOut;

                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        IEnumerable<IShop> IBrowserKernel.GetShops()
        {
            try
            {
                return _repository.GetShops();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
