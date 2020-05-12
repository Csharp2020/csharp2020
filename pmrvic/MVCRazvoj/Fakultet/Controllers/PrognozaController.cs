using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Fakultet.Factory;
using Fakultet.Models;
using Fakultet.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Fakultet.Controllers
{
    public class PrognozaController : Controller
    {
        private readonly IConfiguration Configuration;
        private readonly IOptions<MySettingsModel> appSettings;
        private readonly HttpClient _httpClient;
        public PrognozaController(IOptions<MySettingsModel> app, IConfiguration configuration)
        {
            this.Configuration = configuration;
            appSettings = app;
            ApplicationSettings.WebApiUrl = appSettings.Value.WebApiBaseUrl;
            //ApplicationSettings.WebApiUrl = "localhost:44385/api/";
            //ApplicationSettings.WebApiUrl = Configuration.GetSection("MySettings").GetSection("WebApiBaseUrl").Value;
        }

        // GET: ZaNapraviti
        /*
         * Ovo prikazuje sve TODOITEMS 
         * https://localhost:44385/api/TodoItems
         * */
        public async Task<IActionResult> Index()
        {
            //var data = await ApiClientFactory.Instance.GetTODOS();
            //var response = await SaveUser();
            //  ApiClient apiClient = new ApiClient(new Uri(Configuration.GetSection("MySettings").GetSection("WebApiBaseUrl").Value));
            ApiClient apiClient = new ApiClient(new Uri(ApplicationSettings.WebApiUrl));
            var data = await apiClient.GetPrognoza();
            return View(data);
        }

        //TODO pokusaj dohvatiti samo jedan zapis
        // GET: ZaNapraviti/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
    }
}