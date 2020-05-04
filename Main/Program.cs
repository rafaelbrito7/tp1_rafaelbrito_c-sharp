using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int optionSelected;
            int x, y;
            const int FLAG = 5;
            const string MSG_MENU = "\n1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Sair\n\nEscolha uma opção: ";
            
            
            optionSelected = Menu(MSG_MENU);
            while(optionSelected != FLAG) {
                    switch(optionSelected) {
                    case 1: 
                    x = ReadNumber("\nDigite o primeiro número: ");
                    y = ReadNumber("Digite o segundo número: ");
                    Console.WriteLine("Resultado: " + calculator.Addition(x, y));
                    break;

                    case 2: 
                    x = ReadNumber("\nDigite o primeiro número: ");
                    y = ReadNumber("Digite o segundo número: ");
                    Console.WriteLine("Resultado: " + calculator.Subtraction(x, y));
                    break;

                    case 3: 
                    x = ReadNumber("\nDigite o primeiro número: ");
                    y = ReadNumber("Digite o segundo número: ");
                    Console.WriteLine("Resultado: " + calculator.Multiplication(x, y));
                    break;

                    case 4: 
                    x = ReadNumber("\nDigite o primeiro número: ");
                    y = ReadNumber("Digite o segundo número: ");
                    if ((x == 0) | (y == 0)) {
                        Console.WriteLine("Divisão por 0 não é possível!");
                        break;
                    } 
                    Console.WriteLine("Resultado: " + calculator.Division(x, y));
                    break;

                }
                optionSelected = Menu(MSG_MENU);
            };
            Console.WriteLine("FIM");
        }

        public static int Menu(string msg) {
            int menuOption = 0;

            do {
                try {
                   Console.Write(msg);
                   menuOption = int.Parse(Console.ReadLine());
                   
                   if((menuOption < 1 ) | (menuOption > 5)){
                       Console.WriteLine("Opção Inválida!");
                   }
                } catch(System.FormatException) {
                    Console.WriteLine("Opção Inválida");
                } 
            } while((menuOption < 1 ) | (menuOption > 5));
            
            return menuOption;
        }

        public static int ReadNumber(string message) {
            Console.Write(message);
            var num = int.Parse(Console.ReadLine());

            return num;
        }
    }
}
