using NLog;
using System;

namespace CalculatorApp
{
    public class CalculatorLib
    {
        public double DoMath(string op, params double[] num)
        {
            try
            {
                if (op.Equals("divide"))
                {
                    try
                    {
                        if (num.Length == 2)
                        {
                            return num[0] / num[1];
                        }
                        else
                        {
                            throw new InvalidArgumentsException(op, num);
                        }
                    }
                    catch (InvalidArgumentsException ex)
                    {
                        Logger logger = LogManager.GetLogger("fileLogger");
                        logger.Error(ex, "Divide Error");
                        Console.WriteLine(ex.Message);
                        return 0;
                    }
                }
                else if (op.Equals("add"))
                {
                    double result = 0;
                    for (int i = 0; i < num.Length; i++)
                    {
                        result += num[i];
                    }
                    return result;
                }
                else if (op.Equals("multiply"))
                {
                    double result = 1;
                    for (int i = 0; i < num.Length; i++)
                    {
                        result = result * num[i];
                    }
                    return result;
                }
                else if (op.Equals("subtract"))
                {
                    try
                    {
                        if (num.Length == 2)
                        {
                            return num[0] - num[1];
                        }
                        else
                        {
                            throw new InvalidArgumentsException(op, num);

                        }
                    }
                    catch (InvalidArgumentsException ex)
                    {
                        Logger logger = LogManager.GetLogger("fileLogger");
                        logger.Error(ex, "Subtract Error");
                        Console.WriteLine(ex.Message);
                        return 0;
                    }
                }
                else
                {
                    throw new InvalidOpException(op);
                }
            }
            catch(InvalidOpException ex)
            {
                Logger logger = LogManager.GetLogger("fileLogger");
                logger.Error(ex, "Operation Error");
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
    [Serializable]
    class InvalidArgumentsException : Exception
    {
        public InvalidArgumentsException()
        {

        }

        public InvalidArgumentsException(string op, params double[] num)
            : base(String.Format($"Invalid Arguments. {op} accepts exactly 2 doubles as arguments"))
        {

        }

    }
    [Serializable]
    class InvalidOpException : Exception
    {
        public InvalidOpException()
        {

        }

        public InvalidOpException(string op)
            : base(String.Format($"Invalid Operation. op must be add, subtract, multiply, or divide."))
        {

        }

    }
}
