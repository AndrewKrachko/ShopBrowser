using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBrowser.UI.Models
{
    public class ShopModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public string Description { get; set; }
    }
}
