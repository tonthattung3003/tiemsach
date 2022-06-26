using Microsoft.AspNetCore.Components;
using TiemSach.Shared;

namespace TiemSach.Client.Pages
{
    partial class ShoppingBasket
    {
        [Parameter]
        public IEnumerable<int> Orders { get; set; } = default!;
        [Parameter]
        public EventCallback<int> Selected { get; set; } = default!;
        [Parameter]
        public Func<int, Sach> GetSachFromId { get; set; }
        = default!;
        private IEnumerable<(Sach sach, int pos)> Sachs { get; set; } = default!;
        private decimal TotalPrice { get; set; } = default!;
        protected override void OnParametersSet()
        {
            Sachs = Orders.Select((id, pos)
            => (sach: GetSachFromId(id), pos: pos));
            TotalPrice = Sachs.Select(tuple
            => tuple.sach.Price).Sum();
        }
    }
}
