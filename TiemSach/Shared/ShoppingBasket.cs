using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemSach.Shared {
    public class ShoppingBasket {
        public Customer Customer { get; set; } = new Customer();
        public List<int> Orders { get; set; } = new List<int>();
        public bool HasPaid { get; set; }
        public void Add(int sachId)
        => Orders.Add(sachId);
        public void RemoveAt(int pos)
       => Orders.RemoveAt(pos);
    }
}
