using System;

class Program
{
    static void Main(string[] args)
    {
        var calculator = new Calculator();
        bool continueCalculating = true;

        while(continueCalculating)
        {
            try
            {
                Display.DisplayMenu();
                var operation = Display.GetOperation();

                if(operation == OperationType.Sair)
                {
                    continueCalculating = false;
                    Console.WriteLine("\nObrigado por usar a caluladora!");
                    continue;
                }

                var (firstNumber, secondNumber) = Display.GetNumbers();
                var result = calculator.Calculate(operation, firstNumber, secondNumber);

                Display.DisplayResult(operation, firstNumber, secondNumber, result);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("\nErro: Não é possível dividir por zero!");
            }
            catch(FormatException)
            {
                Console.WriteLine("\nErro: Por favor, insira apenas numeros!");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"\nErro inesperado: {ex.Message}");
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}