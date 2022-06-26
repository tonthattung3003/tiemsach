using Microsoft.AspNetCore.Components;
using TiemSach.Shared;

namespace TiemSach.Client.Pages
{
    partial class SachList
    {
        [Parameter]
        public string Title { get; set; } = default!;
        [Parameter]
        public IEnumerable<Sach> Items { get; set; } = default!;
        [Parameter]
        public string ButtonClass { get; set; } = default!;
        [Parameter]
        public string ButtonTitle { get; set; } = default!;
        [Parameter]
        public EventCallback<Sach> Selected { get; set; }
    }
}
