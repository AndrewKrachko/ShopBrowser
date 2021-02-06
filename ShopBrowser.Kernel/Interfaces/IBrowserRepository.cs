using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBrowser.Kernel
{
    public interface IBrowserRepository
    {
        bool GetShop(int id, out IShop shop);
        List<IShop> GetShops();
    }
}
