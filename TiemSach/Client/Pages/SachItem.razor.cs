using Microsoft.AspNetCore.Components;
using TiemSach.Shared;

namespace TiemSach.Client.Pages
{
    partial class SachItem
    {
        [Parameter]
        public Sach Sach { get; set; } = default!;
        [Parameter]
        public string ButtonTitle { get; set; } = default!;
        [Parameter]
        public string ButtonClass { get; set; } = default!;
        [Parameter]
        public EventCallback<Sach> Selected { get; set; }
        private string LoaisachImage(Loaisach loaisach)
        => $"images/{loaisach.ToString().ToLower()}.png";
    }
}
