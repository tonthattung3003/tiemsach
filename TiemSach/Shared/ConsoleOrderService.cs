using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemSach.Shared {
    public class ConsoleOrderService : IOrderService {
        public ValueTask PlaceOrder(ShoppingBasket basket) {
            Console.WriteLine($"Placing order for {basket.Customer.Name}");
            // .NET 6 now has a CompletedTask which is better...
            return ValueTask.CompletedTask;
        }
    }
}
