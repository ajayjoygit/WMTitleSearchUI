using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WarnerMedia.Data.Entities;
using WarnerMedia.Data.Models;
using WarnerMedia.ViewModels;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WarnerMedia.Controllers
{
    [Route("api/{searchDesc}")]
    [ApiController]
    public class WebApiController : ControllerBase
    {
        private static readonly HttpClient client = new HttpClient();
        public async Task<List<TitleDetails>> TitleResults(string searchDesc)
        {
            string titleApiUrl = "https://localhost:44310/api/Titles/search/"+searchDesc;
            var request = WebRequest.Create(@titleApiUrl);

            var response = await request.GetResponseAsync().ConfigureAwait(false);
            //check the response status for response status 
            var responseReader = new StreamReader(response.GetResponseStream());
            var responseData = await responseReader.ReadToEndAsync();
            var titles = JsonConvert.DeserializeObject<List<TitleDetails>>(responseData);
            return titles;       
        }
    }
}
