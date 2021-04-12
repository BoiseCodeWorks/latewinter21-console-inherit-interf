using latewinter21_inhteritance_interfaces.Interfaces;

namespace latewinter21_inhteritance_interfaces.Models
{
  public class Kaleb : Person, IDeveloper, IMusician, IProducer
  {
    public Kaleb(string name, int age, int repositories) : base(name, age)
    {
      Repositories = repositories;
    }

    public int Repositories { get; set; }
    public override void MakeMoney()
    {
      System.Console.WriteLine("I don't");
    }

    public void EatDoritos()
    {
      throw new System.NotImplementedException();
    }

    public void WriteCode(Music music)
    {
      System.Console.WriteLine("Why doesn't this work.");
    }

    Music IMusician.MakeMusic()
    {
      System.Console.WriteLine("Playin some notes on the ole guitar.");
      return new Music();
    }

    Music IProducer.MakeMusic()
    {
      System.Console.WriteLine("Mastering the tracks on ableton");
      return new Music();
    }
  }
}