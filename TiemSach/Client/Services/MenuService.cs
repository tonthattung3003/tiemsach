using TiemSach.Shared;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
namespace TiemSach.Client.Services {
    public class MenuService : IMenuService {
        private readonly HttpClient httpClient;
        public MenuService(HttpClient httpClient) {
            this.httpClient = httpClient;
        }
        public async ValueTask<Menu> GetMenu() {
            var sachs = await httpClient
                .GetFromJsonAsync<Sach[]>("/sachs");
            return new Menu { Sachs = sachs!.ToList() };
        }
    }
}