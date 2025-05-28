namespace Calculator
{
    // This class contains the methods for basic arithmetic operations
    public class Math
    {
        public double dNum1;
        public double dNum2;
        public double dLastResult;
        public Math(double dNum1, double dNum2)
        {
            this.dNum1 = dNum1;
            this.dNum2 = dNum2;
        }
        public Math(double dNum1, double dNum2, double dLastResult)
        {
            this.dNum1 = dNum1;
            this.dNum2 = dNum2;
            this.dLastResult = dLastResult;
        }

        public double Add()
        {
            dLastResult = dNum1 + dNum2;
            return dLastResult;
        }
        public double Subtract()
        {
            dLastResult = dNum1 - dNum2;
            return dLastResult;
        }
        public double Multiply()
        {
            dLastResult = dNum1 * dNum2;
            return dLastResult;
        }
        public double Divide()
        {
            if (dNum2 == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            dLastResult = dNum1 / dNum2;
            return dLastResult;
        }
    }
}