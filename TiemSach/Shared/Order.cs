using System.Collections.Generic;
namespace TiemSach.Shared {
    public class Order {
        public int Id { get; set; }
        public Customer Customer { get; set; } = default!;
        public ICollection<Sach> Sachs { get; set; } = default!;
    }
}