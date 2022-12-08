using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.CW2.Thursday
{
    internal class MyCalculator
    {
        public int Sum(params int[] values) =>
            DoOperation((left, right) => { return left + right; }, values);

        public int Minus(params int[] values) =>
            DoOperation((left, right) => { return left - right; }, values);

        public int Multiply(params int[] values) =>
            DoOperation((left, right) => { return left * right; }, values);
        public double Division(params double[] values) =>
            DoOperation((left, right) => { return left / right; }, values);

        public double CalculateWhole(string wholeInput)
        {
            int result = 0;
            var sumSentences = wholeInput.Split(new string[] { " + " }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var sentences in sumSentences)
            {
                double currentMinusResult = 0;
                var minusSentences = sentences.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                var minusElements = new double[] { };
                foreach (var currentMinus in minusSentences)
                {
                    minusElements = minusElements.Append(DoStringOperation(currentMinus)) as double[];
                }

                currentMinusResult = DoOperation(
                    (left, right) => left - right, minusElements);
            }



            return 0;
        }

        public double DoStringOperation(string wholeInput)
        {
            var results = new double[] { };
            var divideSentences = wholeInput.Split(" / ");
            foreach (var sentences in divideSentences)
            {
                double innerResult = 0;
                if (sentences.Contains(" * "))
                {
                    var multipleSentences = sentences.Split(" * ");
                    var doubleValues = multipleSentences.Select(
                        (value) => { return Convert.ToDouble(value); }) as double[];
                    innerResult = DoOperation(
                        (left, right) => { return left * right; }, doubleValues);
                }
                else
                {
                    innerResult = Convert.ToDouble(wholeInput);
                }

                results = results.Append(innerResult) as double[];
            }

            return DoOperation(
                (left, right) => left / right, results);
        }

        private int DoOperation(Func<int, int, int> theOperator, params int[] values)
        {
            int result = 0;
            foreach (var value in values) 
            {
                result = theOperator.Invoke(result, value);
            }

            return result;
        }
        private double DoOperation(Func<double, double, double> theOperator, params double[] values)
        {
            double result = 0;
            foreach (var value in values)
            {
                result = theOperator.Invoke(result, value);
            }

            return result;
        }
    }
}
