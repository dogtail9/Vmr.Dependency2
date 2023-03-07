using Vmr.Dependency1;

namespace Vmr.Dependency2
{
    public class ExtendedCalculator : Calculator
    {
        public int Multiply(int arg1, int arg2)
        {
            return arg1 * arg2;
        }

        public int Divide(int arg1, int arg2)
        {
            return arg1 / arg2;
        }
    }
}