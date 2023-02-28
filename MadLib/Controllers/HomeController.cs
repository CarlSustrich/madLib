using Microsoft.AspNetCore.Mvc;
using MadLib.Models;


namespace MadLib.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Splash() 
    {return View();}

    [Route("/form")]
    public ActionResult Form() {return View();}
    [Route("/DAForm")]
    public ActionResult DAForm() {return View();}
    [Route("/CodingForm")]
    public ActionResult CodingForm() {return View();}

    [Route("/TolkienMadLib")]
    public ActionResult TolkienMadLib(string fruit,string pluralnoun1, string noun1, string noun2, string pluralnoun2, string noun3, string sillyword)
    {
      MadderLib newMadLib = new MadderLib(fruit, pluralnoun1, noun1, noun2, pluralnoun2, noun3, sillyword);
      return View(newMadLib);
    }
    
    [Route("/CodingMadLib")]
    public ActionResult CodingMadLib(string Adjective1, string ProgrammingLanguage, string Noun, string Number, string ProgrammingConcept, string PluralNoun, string Adverb, string Adjective3, string Adjective2)
    {
      MadderLib newMadLib = new MadderLib(Adjective1, ProgrammingLanguage, Noun, Number, ProgrammingConcept, PluralNoun, Adverb, Adjective3, Adjective2);
      return View(newMadLib);

    }

    [Route("/DragonAgeMadLib")]
    public ActionResult DragonAgeMadLib(string DARace, string Animal, string Name, string Adverb1, string Adjective2, string DAClass, string Adjective3, string DATerm)
    {
      MadderLib newMadLib  = new MadderLib(DARace, Animal, Name, Adverb1, Adjective2, Adjective3, DAClass, DATerm);
      return View(newMadLib);
    }
  }
}
