class Calc
{
    public double answer;
    Num1 num1 = new Num1();
    Num2 num2 = new Num2();

    public void add()
    {
        answer = (num1.getNum() + num2.getNum());
        System.Console.Write("Результат: ");
        System.Console.WriteLine(+answer);
    }
    public void dif()
    {
        answer = (num1.getNum() - num2.getNum());
        System.Console.Write("Результат: ");
        System.Console.WriteLine(+answer);
    }
    public void mult()
    {
        answer = (num1.getNum() * num2.getNum());
        System.Console.Write("Результат: ");
        System.Console.WriteLine(+answer);
    }
    public void divide()
    {
        answer = (num1.getNum() / num2.getNum());
        System.Console.Write("Результат: ");
        System.Console.WriteLine(+answer);
    }
}