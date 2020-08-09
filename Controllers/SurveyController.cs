using System;
using Microsoft.AspNetCore.Mvc;
namespace Dojo_Survey
{
  public class SurveyController : Controller
  {
    [HttpGet("")]
    public ViewResult Survey()
    {
      return View();
    }

    [HttpPost]
    [Route("result")]
    public IActionResult Method(string name, string dojo, string favlang, string comments)
    {
      ViewBag.Name = name;
      ViewBag.Dojo = dojo;
      ViewBag.FavLang = favlang;
      ViewBag.Comment = comments;
      return View("SurveyResult");
    }
  }
}