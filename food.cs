using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgPoe
{
    internal class Food
    {
     namespace Hello
    }
}

    class recipie
    {//sub class where the methods will be pulled from by creating object in class and putting it in main method
     //data entered in the data method is floating/being kept in this class until code for storing is created
        private String[] ingredients;
        private double[] amount;
        private String[] units;
        private String[] steps;

        public recipie(string[] ingredients, double[] amount, string[] units, string[] steps)
        {
            ingredients = ingredients;
            amount = amount;
            units = units;
            steps = steps;
        }

        public recipie()
        {
        }

        public void EnterData() //this is the enter data method
        {
            Console.WriteLine("Enter number of ingredients");
            int number = Convert.ToInt32(Console.ReadLine());

            ingredients = new string[number];
            amount = new double[number];
            units = new String[number];

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Enter ingredient details#{i + 1}:");
                Console.WriteLine("Name: ");
                ingredients[i] = Console.ReadLine();
                Console.WriteLine("Quantity");
                amount[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("units of measurement");
                units[i] = Console.ReadLine();
            }

            Console.WriteLine("please enter steps:");
            int stpNum = Convert.ToInt32(Console.ReadLine());
            steps = new string[stpNum];

            for (int a = 0; a < stpNum; a++)
            {
                Console.WriteLine($"steps#{a + 1};");
                steps[a] = Console.ReadLine();

            }


        }

        public void recipieDisplay() //this code will display the written information on the enter data method
        {
            Console.WriteLine("enter ingredients:");
            for (int i = 0; i < ingredients.Length; i++)
            {
                Console.WriteLine($" - {amount[i]}{units[i]} of {ingredients[i]}");
            }
            Console.WriteLine("steps");
            for (int a = 0; a < steps.Length; a++)
            {
                Console.WriteLine($"-{steps[a]}");
            }

        }

        public void recipieScale(double scale)//this code will print the scale of the recipie 
        {
            for (int i = 0; i < amount.Length; i++)
            {
                amount[i] *= scale;
            }
        }

        public void resetRecipie()
        {
            for (int i = 0; i < amount.Length; i++)
            {
                amount[i] /= 2; //the code will allow the usee to reset entered recipie


            }

        }

        // public void recipieUpdate() { } remember to check on this youll need it in the future

        public void clearRecipie()
        {
            ingredients = setIngredients(new String);
            amount = setAmount(new Double[0]);
            units = setUnits(new String[0]);
            steps = setSteps(new String[0]);

        }
        public void setUnits(String[] units)
        {
            this.units = units;
        }
        public string[] getUnits()
        {
            return units;
        }
        public void setSteps(String[] steps)
        {
            this.steps = steps;
        }
        public string[] getSteps()
        {
            return steps;
        }
        public void setIngredients(String[] ingredients)
        {
            this.units = ingredients;
        }
        public string[] getIngredietns()
        {
            return ingredients;
        }
        public void setAmount(String[] amount)
        {
            this.units = amount;
        }
        public string[] Amount()
        {
            return amount;
        }
    }
}