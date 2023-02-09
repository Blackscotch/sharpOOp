namespace Main
{
    public class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Выберите операцию (+) (-) (*) (/)");
            System.Console.Write("Укажите операцию: ");
            char Operation = char.Parse(Console.ReadLine());
            Num1 num1 = new Num1();
            Num2 num2 = new Num2();
            Calc res = new Calc();
            if (Operation == '+')
            {
                res.add();
            }
            if (Operation == '-')
            {
                res.dif();
            }
            if (Operation == '*')
            {
                res.mult();
            }
            if (Operation == '/')
            {
                res.divide();
            }
        }
        
    }
}

