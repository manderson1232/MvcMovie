//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Net.Http;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
//using Microsoft.AspNetCore.Mvc;



//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace MvcMovie
//{
//  [Route("api/[controller]")]
//public class omdbMovieController : Controller
//{
//[HttpGet]
//  public async Task<IActionResult> GetMovie(string title)
//{

//  HttpClient client = new HttpClient();

//string url = $"http://www.omdbapi.com/?apikey=" ;
//var response = await client.GetAsync(url);
//var data = await response.Content.ReadAsStringAsync();

//var json = JsonConvert.DeserializeObject(data).ToString();
//dynamic omdbMovie = JObject.Parse(json);
//            ViewData["Json"] = json;

//return View();
//}


//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
//// GET: api/<controller>

//    }
//}
