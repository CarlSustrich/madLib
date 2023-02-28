namespace MadLib.Models
{

  public class MadderLib 
  {
    public string Fruit {get;set;}
    public string PluralNoun1 {get;set;}
    public string Noun1 { get; set; }
    public string Noun2 {get;set;}
    public string PluralNoun2 {get;set;}
    public string Noun3 { get; set; }
    public string SillyWord {get;set;}
    public string Adjective1 {get;set;}
    public string ProgrammingLanguage {get;set;}
    public string Noun { get; set; }
    public string Number {get;set;}
    public string ProgrammingConcept {get;set;}
    public string PluralNoun { get; set; }
    public string Adverb {get;set;}
    public string Adjective3 {get;set;}
    public string Adjective2 {get;set;}
    public string DARace {get;set;}
    public string Animal {get;set;}
    public string Name {get;set;}
    public string Adverb1 {get;set;}
    public string DAClass {get;set;}
    public string DATerm {get;set;}

    public MadderLib (string fruit, string pluralnoun1, string noun1, string noun2, string pluralnoun2, string noun3, string sillyword)
    {
    
      Fruit = fruit;
      PluralNoun1 = pluralnoun1;
      Noun1 = noun1;
      Noun2 = noun2;
      PluralNoun2 = pluralnoun2;
      Noun3 = noun3;
      SillyWord = sillyword;
    }

    public MadderLib (string Adjective1, string ProgrammingLanguage, string Noun, string Number, string ProgrammingConcept, string PluralNoun, string Adverb, string Adjective3, string Adjective2)
    {
      this.Adjective1 = Adjective1;
      this.ProgrammingLanguage = ProgrammingLanguage;
      this.Noun = Noun;
      this.Number = Number;
      this.ProgrammingConcept = ProgrammingConcept;
      this.PluralNoun = PluralNoun;
      this.Adverb = Adverb;
      this.Adjective3 = Adjective3;
      this.Adjective2 = Adjective2;
    }
    public MadderLib (string DARace, string Animal, string Name, string Adverb1, string Adjective2, string DAClass, string Adjective3, string DATerm)
    {
    this.DARace = DARace;
    this.DATerm = DATerm;
    this.Adjective3 = Adjective3;
    this.Adjective2 = Adjective2;
    this.Adjective1 = Adjective1;
    this.Animal = Animal;
    this.Name = Name;
    }

  
  }
}
