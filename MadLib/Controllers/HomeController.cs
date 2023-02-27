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
      LetterVariable newMadLib = new LetterVariable();
      newMadLib.Fruit = fruit;
      newMadLib.PluralNoun1 = pluralnoun1;
      newMadLib.Noun1 = noun1;
      newMadLib.Noun2 = noun2;
      newMadLib.PluralNoun2 = pluralnoun2;
      newMadLib.Noun3 = noun3;
      newMadLib.SillyWord = sillyword;
      return View(newMadLib);
    }
    
    [Route("/CodingMadLib")]
    public ActionResult CodingMadLib(string Adjective1, string ProgrammingLanguage, string Noun, string Number, string ProgrammingConcept, string PluralNoun, string Adverb, string Adjective3, string Adjective2)
    {
      CodingVariable newMadLib = new CodingVariable();
      newMadLib.Adjective1 = Adjective1;
      newMadLib.ProgrammingLanguage = ProgrammingLanguage; 
      newMadLib.Noun = Noun; 
      newMadLib.Number = Number; 
      newMadLib.ProgrammingConcept = ProgrammingConcept; 
      newMadLib.PluralNoun = PluralNoun; 
      newMadLib.Adverb = Adverb; 
      newMadLib.Adjective3 = Adjective3; 
      newMadLib.Adjective2 = Adjective2; 
      return View(newMadLib);

    }

    [Route("/DragonAgeMadLib")]
    public ActionResult DragonAgeMadLib(string DARace, string Animal, string Name, string Adverb1, string Adjective2, string DAClass, string Adjective3, string DATerm)
    {
      DAVariable newMadLib  = new DAVariable();
      newMadLib.DARace = DARace;
      newMadLib.Animal = Animal;
      newMadLib.Name = Name;
      newMadLib.Adverb1 = Adverb1;
      newMadLib.Adjective2 = Adjective2;
      newMadLib.DAClass = DAClass;
      newMadLib.Adjective3 = Adjective3;
      newMadLib.DATerm = DATerm;
      return View(newMadLib);
    }
  }
}
