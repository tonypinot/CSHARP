namespace MSTest_Example.Utilities
{
    public static class Math
    {
        public static int Factorial(int a)
        {
            if (a <= 1)
            {
                return 1;
            }                

            return a * Factorial(a - 1);
        }
    }
}