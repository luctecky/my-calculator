public static class Display
{
	public static void DisplayMenu()
	{
		Console.WriteLine("======Calculadora======");
		Console.WriteLine("1 - Soma");
		Console.WriteLine("2 - Subtração");
		Console.WriteLine("3 - Multiplicação");
		Console.WriteLine("4 - Divisão");
		Console.WriteLine("5 - Sair");
		Console.WriteLine("=======================");
	}

	public static OperationType GetOperation()
	{
		while (true)
		{
			Console.Write("\nEscolha uma Operação (1-5): ");
			if (Enum.TryParse(Console.ReadLine(), out OperationType operation) && Enum.IsDefined(typeof(OperationType), operation))
			{
				return operation;
			}
			Console.WriteLine("Operação Inválida! Por favor escolha outra operação!");
		}
	}

	public static void DisplayResult(OperationType operation, double firstNumber, double secondNumber, double result)
	{
		string operationSymbol = operation switch
		{
			OperationType.Soma => "+",
			OperationType.Subtração => "-",
			OperationType.Multiplicação => "*",
			OperationType.Divisão => "/",
			_ => throw new ArgumentException("Operação inválida!")
		};

		Console.WriteLine($"\n {firstNumber:N2} {operationSymbol} {secondNumber:N2} = {result:N2}");
	}

	public static (double firstNumber, double secondNumber) GetNumbers()
	{
		Console.Write("\nDigite o primeiro número: ");
		double firstNumber = Convert.ToDouble(Console.ReadLine());

		Console.Write("\nDigite o segundo número: ");
		double secondNumber = Convert.ToDouble(Console.ReadLine());

		return (firstNumber, secondNumber);
	}
}