public class Num2 : Num
{
    public override double getNum()
    {
        System.Console.WriteLine("Введите второе число: ");
        Enum = Double.Parse(Console.ReadLine());
        return Enum;
    }
}