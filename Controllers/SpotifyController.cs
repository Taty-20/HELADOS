using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;


using HeladeriaTAMS.DTO.gorest;
using HeladeriaTAMS.DTO.spotify;

namespace HeladeriaTAMS.Controllers
{

    public class SpotifyController : Controller
    {
        private readonly ILogger<SpotifyController> _logger;
        private const string URL_BASE="https://gorest.co.in";
        //private const string URL_BASE_SPOTIFY="https://api.spotify.com/v1/me";
        //private const string URL_BASE="https://gorest.co.in";
        //private const string URL_API="/v1/me";
        private const string URL_API="/public/v2/users";
        private const string ACCESS_TOKEN = "BQDwTuLUE8zdvKcPUeBYK7QGT9Mp_cg8v2TGyiqUfjqPiSe29_JkRF-w4ctgyr6uwam7HT9i1LImo_0fn11mt1y8EhrE5uo8pwhWwsZjYz2tq2rjuLYTOCI-Km2W1aSwLJXqCWt-XkOrGY6SmVu6PEoKLJPSyKqG193qu8InTqT6kJ3jMQLhwTjjuYWQP4W-BONuPSwd-k3M";
        
        

        public SpotifyController(ILogger<SpotifyController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index(string? strtoken)
        {
            var token = ACCESS_TOKEN;
            if (!String.IsNullOrEmpty(strtoken)){
                token = strtoken;
            }
            
            var httpclient = new HttpClient();
            httpclient.DefaultRequestHeaders.Accept.Clear();
            httpclient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpclient.BaseAddress = new Uri(URL_BASE);
            //httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",token);
            HttpResponseMessage response = await httpclient.GetAsync(URL_API);
            List<Users>? me= await response.Content.ReadFromJsonAsync<List<Users>>();
            //HttpResponseMessage response = await httpclient.PostAsync(URL_API,input);
            //UserSpotify? me = await response.Content.ReadFromJsonAsync<UserSpotify>();
            return View("IndexGorest",me);
            //return View(me);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}