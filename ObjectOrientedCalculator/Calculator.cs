namespace ObjectOrientedCalculator
{
    class Calculator
    {
        public double firstNumber;
        public double secondNumber;
        public double result;
        public string operationHistory = "\n##### Operations #####\n";


        public double Add()
        {
            result = firstNumber + secondNumber;
            operationHistory += $"{firstNumber} + {secondNumber} = " + result.ToString() + "\n";
            return result;
        }

        public double Sub()
        {
            result = firstNumber - secondNumber;
            operationHistory += $"{firstNumber} - {secondNumber} = " + result.ToString() + "\n";
            return result;
        }

        public double Multiple()
        {
            result = firstNumber * secondNumber;
            operationHistory += $"{firstNumber} * {secondNumber} = " + result.ToString() + "\n";
            return result;
        }

        public double Division()
        {
            if (secondNumber != 0)
            {
                result = firstNumber / secondNumber;
                operationHistory += $"{firstNumber} / {secondNumber} = " + result.ToString() + "\n";
            }
            return result;
        }
    }
}
