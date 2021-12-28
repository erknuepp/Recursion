namespace Recursion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Xamarin.Forms;

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void directRecursionButtonClick(object sender, EventArgs e)
        {
            long fact = GetFactorialDirectRecusion(Convert.ToInt32(numberInput.Text));
            directRecusionCalculation.Text = fact.ToString();
        }

        public void indirectRecursionButtonClick(object sender, EventArgs e)
        {
            long fact = GetFactorialIndirectRecusion(Convert.ToInt32(numberInput.Text));
            indirectRecusionCalculation.Text = fact.ToString();
        }

        public void iterationButtonClick(object sender, EventArgs e)
        {
            long fact = GetFactorialIteration(Convert.ToInt32(numberInput.Text));
            iterationCalculation.Text = fact.ToString();
        }

        private long GetFactorialIteration(long number)
        {
            var fact = number;
            for (long i = number - 1; i > 0; i--)
            {
                fact = fact * i;
            }
            return fact;
        }

        private static long GetFactorialDirectRecusion(long number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * GetFactorialDirectRecusion(number - 1);
        }

        private static long GetFactorialIndirectRecusion(long number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * Foo(number - 1);
        }

        private static long Foo(long number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * GetFactorialIndirectRecusion(number - 1);
        }
    }
}
