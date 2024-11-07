public class Calculator
{
    public double Calculate(OperationType operation, double firstNumber, double secondNumber)
    {
        return operation switch
        {
            OperationType.Soma => firstNumber + secondNumber,
            OperationType.Subtração => firstNumber - secondNumber,
            OperationType.Multiplicação => firstNumber * secondNumber,
            OperationType.Divisão => secondNumber != 0 ? firstNumber / secondNumber
                :throw new DivideByZeroException(),
            _=> throw new ArgumentException("Operação Inválida!")
        };
    }
}