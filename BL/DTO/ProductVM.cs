using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTO
{
    public class ProductVM
    {
        public int ID { get; set; }
        public string SKU { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public bool IsActive { get; set; }
    }
}
