using latewinter21_inhteritance_interfaces.Interfaces;

namespace latewinter21_inhteritance_interfaces.Models
{
  public class Tim : Person, IDeveloper
  {
    public Tim(string namez, int age, int repositories) : base(namez, age)
    {
      Repositories = repositories;
    }

    public int Repositories { get; set; }


    public override void MakeMoney()
    {
      System.Console.WriteLine("Writing codes");
    }

    public override decimal WillToLive()
    {
      return 10000 / Age;
    }

    public void EatDoritos()
    {
      throw new System.NotImplementedException();
    }


    //if you ever implement explicitly you will need to cast to that type before calling method
    void IDeveloper.WriteCode(Music music)
    {
      System.Console.WriteLine("Anything but carousels.");
    }

    // public void WriteCode()
    // {
    //   System.Console.WriteLine("Anything but carousels.");
    // }
  }
}