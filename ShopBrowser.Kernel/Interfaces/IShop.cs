using System;

namespace ShopBrowser.Kernel
{
    public interface IShop
    {
        public int Id { get; set; }
        public string ShopName { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public string Description { get; set; }
    }
}