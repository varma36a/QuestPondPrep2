// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;



public interface ISwimmable
{
    public string Color { get; set; }

    public void Swim();
}

public interface IFylable
{
    public string Color { get; set; }
    public void Fly();

}

public abstract class Bird
{
    public void Speak()
    {

    }
}


public class Pegion : Bird, IFylable
{

    string color = "";
    public string Color { get => this.Color; set => setColor(); }

    public Pegion()
    {
        setColor();
    }

    public string setColor()
    {
        this.color = "red";
        return this.color;
    }
    public void Fly()
    {

    }
}








