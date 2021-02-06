using System.Collections.Generic;

namespace ShopBrowser.Kernel
{
    public interface IBrowserKernel
    {
        bool GetShop(int id, out IShop shop);
        IEnumerable<IShop> GetShops();
    }
}