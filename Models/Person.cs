namespace latewinter21_inhteritance_interfaces.Models
{
  public abstract class Person
  {
    protected Person(string name, int age)
    {
      Name = name;
      Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }


    public abstract void MakeMoney();

    public virtual decimal WillToLive()
    {
      return 100 / Age;
    }



  }
}