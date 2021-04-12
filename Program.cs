using System;
using System.Collections.Generic;
using latewinter21_inhteritance_interfaces.Interfaces;
using latewinter21_inhteritance_interfaces.Models;

namespace latewinter21_inhteritance_interfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Tim tim = new Tim("Tim", 9, 500);
      //   tim.MakeMoney();
      Kaleb kaleb = new Kaleb("Kaleb", 27, 250);
      //   kaleb.MakeMoney();

      //   System.Console.WriteLine(tim.WillToLive());
      //   System.Console.WriteLine(kaleb.WillToLive());

      Music kalebsMusic = (kaleb as IMusician).MakeMusic();

      //   (tim as IDeveloper).WriteCode(kalebsMusic);

      List<IDeveloper> developers = new List<IDeveloper>();

      developers.Add(kaleb);
      developers.Add(tim);
      //   developers.Add();
      developers.ForEach(developer =>
      {
        if (developer is Person)
        {
          //   Person p = developer as Person;
          //either one of these will work to cast to a type
          Person p = (Person)developer;
          System.Console.WriteLine($"My name is {p.Name}");
        }

        if (developer is IMusician)
        {
          IMusician musician = (IMusician)developer;
          Music personalMusic = musician.MakeMusic();
          developer.WriteCode(personalMusic);

        }

        developer.WriteCode(kalebsMusic);
      });

      (kaleb as IProducer).MakeMusic();



    }
  }
}
