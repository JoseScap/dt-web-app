using dt_web_app.DTOs;
using dt_web_app.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace dt_web_app.Pages
{
    public class DTsModel : PageModel
    {
        private readonly ILogger<DTsModel> _logger;
        public DT[]? DTs { get; set; }
        public bool showTable { get; set; } = false;

        public DTsModel(ILogger<DTsModel> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> OnGet()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync("http://localhost:7071/api/HttpListDTs");
                    if (!response.IsSuccessStatusCode) return Page();

                    var jsonData = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<GenericResponse<List<DT>, string>>(jsonData);

                    if (data == null) return Page();

                    showTable = true;
                    DTs = data.Data.ToArray();
                }
                catch { }
            }

            return Page();
        }
    }
}