namespace ConsoleApplication1._1_Multiples_Of_3_And_5
{
    class ThreeFiveEvaluator
    {
        public int Evaluate(int number)
        {
            var addedMultiple =0;

            for (var i = 1; i < number; i++)
            {
                if (IsMultipleOfThree(i))
                {
                    addedMultiple = addedMultiple + i;
                }
                else
                {
                    if (IsMultipleOfFive(i))
                    {
                        addedMultiple = addedMultiple + i;
                    }
                }
            }
            return addedMultiple;
        }

        private static bool IsMultipleOfThree(int result)
        {
            return (result % 3 == 0);
        }

        private static bool IsMultipleOfFive(int result)
        {
            return (result % 5 == 0);
        }
    }
}
