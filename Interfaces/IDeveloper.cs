using latewinter21_inhteritance_interfaces.Models;

namespace latewinter21_inhteritance_interfaces.Interfaces
{
  public interface IDeveloper
  {

    int Repositories { get; set; }

    void WriteCode(Music music);

    void EatDoritos();
  }
}