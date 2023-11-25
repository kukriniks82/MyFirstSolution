namespace MySecondConsole;


class Program
{
    static void Main(string[] args)
    {
        //first part
        double pi = 3.141592653;
        decimal e = 1.414213562373095048M;
        Console.WriteLine("pi = " + pi);
         Console.WriteLine("e = " + e);


        //second part
        int a = 3;
        byte b = (byte)a;
        Console.WriteLine("b = " + b);

        //third part
       
        double avarage = 0;
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"input {i} digit");
            string? fromConsole = Console.ReadLine();

            fromConsole = fromConsole.Replace(",", ".");            
                /*не знаю почему, у меня при наличии "," в числе ,например 12,12 считывается как 1212 :)
                 может что VS for MAC*/ 
            {

                bool resul = double.TryParse(fromConsole, out double tempDigit);
                if (resul) // validation
                {
                    avarage += tempDigit;
                }
                else
                {
                    Console.WriteLine("Wrong digit!!!!\n try one time else");
                    i--;
                }
                if (i == 3)
                {
                    Console.WriteLine("avarage = " + avarage / 3);
                }
            }


        }

        Console.WriteLine("press any key");
        Console.ReadKey();
    }
}

