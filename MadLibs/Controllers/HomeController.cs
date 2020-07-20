using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/")]
    public ActionResult Letter()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      myLetterVariable.Destination = "Brazil";
      myLetterVariable.Sender = "Jasmine";
      myLetterVariable.Animal = "Brazil";
      myLetterVariable.Exclamation = "Jasmine";
      return View(myLetterVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }
    
    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender, string destination, string animal, string exclamation)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Destination = destination;
      myLetterVariable.Sender = sender;
      myLetterVariable.Animal = animal;
      myLetterVariable.Exclamation = exclamation;
      return View(myLetterVariable);
    }
  }
}