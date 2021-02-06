using Microsoft.EntityFrameworkCore;
using ShopBrowser.Kernel;
using System;
using System.Collections.Generic;

namespace ShopBrowser.Repository
{
    public class ShopBrowserRepository : IBrowserRepository
    {
        ShopContext _dbContext;

        public ShopBrowserRepository()
        {
            _dbContext = new ShopContext();
            _dbContext.Database.EnsureCreated();
            _dbContext.SaveChanges();
        }

        bool IBrowserRepository.GetShop(int id, out IShop shop)
        {
            try
            {
                shop = _dbContext.ShopEntities.FirstOrDefaultAsync(s => s.Id == id).Result.GetShop;

                if(shop != null)
                {
                    return true;
                }

                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        List<IShop> IBrowserRepository.GetShops()
        {
            try
            {
                var shopEntities = _dbContext.ShopEntities.ToListAsync().Result;

                var shops = new List<IShop>();
                foreach (var shopEntity in shopEntities)
                {
                    shops.Add(shopEntity.GetShop);
                }

                return shops;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
