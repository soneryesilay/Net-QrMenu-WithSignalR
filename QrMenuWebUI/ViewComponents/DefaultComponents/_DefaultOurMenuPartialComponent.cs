using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QrMenuWebUI.Dtos.ProductDtos;
using QrMenuWebUI.Dtos.SliderDtos;

namespace QrMenuWebUI.ViewComponents.DefaultComponents
{
    public class _DefaultOurMenuPartialComponent  : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultOurMenuPartialComponent(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7012/api/Product");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
            return View(values);
        }
    }
}
