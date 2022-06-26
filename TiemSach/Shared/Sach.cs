using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TiemSach.Shared{
    public class Sach {
        public Sach(int id, string name, decimal price,
        Loaisach loaisach) {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Loaisach = loaisach;
        }
        public int Id { get; }
        public string Name { get; }
        public decimal Price { get; }
        public Loaisach Loaisach { get; }
        [JsonIgnore]
        public ICollection<Order>? Orders { get; set; }
    }
}