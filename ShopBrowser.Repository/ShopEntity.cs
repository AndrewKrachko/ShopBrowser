using ShopBrowser.Kernel;
using System;

namespace ShopBrowser.Repository
{
    internal class ShopEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public string Description { get; set; }

        public IShop GetShop => new Shop() { Id = Id, ShopName=Name, OpenTime = OpenTime, CloseTime = CloseTime, Description=Description };
    }
}