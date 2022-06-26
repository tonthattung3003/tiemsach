using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemSach.Shared {
    public class Menu {
        public List<Sach> Sachs { get; set; }
            = new List<Sach>();
        public void Add(Sach sach)
            => Sachs.Add(sach);
        public Sach? GetSach(int id)
            => Sachs.SingleOrDefault(sach => sach.Id == id);
    }
}
