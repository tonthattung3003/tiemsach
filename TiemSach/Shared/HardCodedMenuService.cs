using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemSach.Shared {
    public class HardCodedMenuService : IMenuService {
        public ValueTask<Menu> GetMenu() => new ValueTask<Menu>(
            new Menu {
                Sachs = new List<Sach> {
                    new Sach(1, "Sách tài chính", 8.99M, Loaisach.Taichinh),
                    new Sach(2, "Sách ngôn tình", 7.99M, Loaisach.Ngontinh),
                    new Sach(3, "Sách hư cấu", 9.99M, Loaisach.Hucau)
                }
             });
    }
}

