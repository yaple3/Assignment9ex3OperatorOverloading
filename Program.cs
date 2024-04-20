namespace Assignment9ex3OperatorOverloading
{
    public class MealPlan
    {
        //numeric calories property
        public int TotalCalories { get; set; }
        public List<string> Meals { get; set; } 

        public MealPlan()
        {
            TotalCalories = 0;
            Meals = new List<string>();
        }

        //Create a unary overloaded operator (+, -, !, ~, ++, – –) and use it in your program. Display the results.
        //adding each meal's calories to the total calories
        // Unary overloaded operator to add each meal's calories to the total calories
        public static MealPlan operator ++(MealPlan mealPlan)
        {
            Console.WriteLine("Enter what you're having for breakfast:");
            string breakfast = Console.ReadLine();
            mealPlan.Meals.Add($"Breakfast: {breakfast}");

            Console.WriteLine("Enter the calories for breakfast:");
            int breakfastCalories = int.Parse(Console.ReadLine());
            mealPlan.TotalCalories += breakfastCalories;

            Console.WriteLine("Enter what you're having for lunch:");
            string lunch = Console.ReadLine();
            mealPlan.Meals.Add($"Lunch: {lunch}");

            Console.WriteLine("Enter the calories for lunch:");
            int lunchCalories = int.Parse(Console.ReadLine());
            mealPlan.TotalCalories += lunchCalories;

            Console.WriteLine("Enter what you're having for dinner:");
            string dinner = Console.ReadLine();
            mealPlan.Meals.Add($"Dinner: {dinner}");

            Console.WriteLine("Enter the calories for dinner:");
            int dinnerCalories = int.Parse(Console.ReadLine());
            mealPlan.TotalCalories += dinnerCalories;

            return mealPlan;
        }


        //Create a comparison overloaded operator (==, !=, =, >, <) and use it in your program. Display the results.
        public static bool operator <(MealPlan mealPlan1, MealPlan mealPlan2)
        {
            bool less = false;
            if (mealPlan1.TotalCalories < mealPlan2.TotalCalories)
            {
                less = true;
            }
            return less;
        }
        public static bool operator >(MealPlan mealPlan1, MealPlan mealPlan2)
        {
            bool more = false;
            if (mealPlan1.TotalCalories > mealPlan2.TotalCalories)
            {
                more = true;
            }
            return more;
        }

        //Create a binary overloaded operator (+, -, *, /, %) and use it in your program. Display the results.
        //finding total calories from combined meals
        public static MealPlan operator +(MealPlan mealPlan1, MealPlan mealPlan2)
        {
            MealPlan combinedCalories = new MealPlan();
            combinedCalories.TotalCalories = mealPlan1.TotalCalories + mealPlan2.TotalCalories;
            return combinedCalories;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            //Create at least 2 objects from user input and add to Meals list and TotalCalories
            MealPlan mealPlan1 = new MealPlan();
            MealPlan mealPlan2 = new MealPlan();
            //Unary overloaded operator to calculate total calories
            Console.WriteLine("Meal Plan 1: ");
            mealPlan1++;
            Console.WriteLine($"Total calories of Meal Plan #1: {mealPlan1.TotalCalories}");
            Console.WriteLine("Meal Plan 2: ");
            mealPlan2++;
            Console.WriteLine($"Total calories of Meal Plan 2: {mealPlan2.TotalCalories}");
            Console.WriteLine();

            //Comparison overloaded operator
            if (mealPlan1 < mealPlan2)
            {
                Console.WriteLine("Meal Plan #1 has less calories than Meal Plan #2");
            }
            else if (mealPlan1 > mealPlan2)
            {
                Console.WriteLine("Meal Plan #1 has more calories than Meal Plan #2");
            }
            else
            {
                Console.WriteLine("Meal Plan #1 has the same amount of calories as Meal Plan #2");
            }
            Console.WriteLine();

            //Binary overloaded operator
            MealPlan combinedCalories = mealPlan1 + mealPlan2;
            Console.WriteLine($"Total calories of both meal plans:  {combinedCalories.TotalCalories}");

        }
    }
}

