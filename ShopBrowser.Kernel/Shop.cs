using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBrowser.Kernel
{
    public class Shop : IShop
    {
        public int Id { get; set; }
        public string ShopName { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public string Description { get; set; }
    }
}
