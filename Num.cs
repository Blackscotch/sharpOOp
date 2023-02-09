public abstract class Num
{
    public double num;
    public double Enum
    {
        get {return num;}
        set {num = value;}
    }
    public virtual double getNum() 
    {
        System.Console.WriteLine("Введите число: ");
        Enum = Double.Parse(Console.ReadLine());
        return Enum;
    }
}