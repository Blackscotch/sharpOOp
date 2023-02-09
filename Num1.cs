public class Num1 : Num
{
    public override double getNum()
    {
        System.Console.WriteLine("Введите первое число: ");
        Enum = Double.Parse(Console.ReadLine());
        return Enum;
    }
}