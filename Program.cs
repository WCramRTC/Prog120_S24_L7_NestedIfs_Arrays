namespace Prog120_S24_L7_NestedIfs_Arrays
{
    internal class Program
    {
        // 3 Levels of variable scope
        // Class Level
        // Method Level
        // Block Level

        static void Main(string[] args)
        {

            // Arrays
            // An array is a COLLECTION of variables of the same TYPE
            // Method Scope
            // To DECLARE AN ARRAY you TYPE[]
            // To INITIALIZE = new type[size]
            int[] vickysGrades = new int[10];

            // How to initilaize an array with values
            int[] willsGrades = new int[] { 10, 45, 99, 14, 56, 87};

            // Change the value of an element
            int changeGrade = 10;
            vickysGrades[0] = 10;


            // To ACCESS an ELEMENT in the array, you use [index]
            // Element is the term for an individual value you an array
            // ALL ARRAYS START AT INDEX 0
            int firstGrade = vickysGrades[0];

            Console.WriteLine(firstGrade);


            Console.WriteLine("Display Wills Grades");

            // i = 0 starts at the beggining of our array
            // length indicate the number of elements in the array
            // array.length
            // The LAST INDEX is ALWAYS .Length - 1
            // Elements: 1,  2,  3,  4, , 5, , 6
            // Values :  10, 45, 99, 14, 56, 87
            // Index:    0,  1,  2,  3,  4,  5


            int totalGrade = 0;

            for (int i = 0; i < willsGrades.Length; i++)
            {
                // Storing the current grade
                int willsCurrentGrade = willsGrades[i];
                totalGrade += willsCurrentGrade;
                int currentElement = i + 1;
                int currentIndex = i;
                string currentGrade = GradeCovertor(willsCurrentGrade);

                Console.WriteLine($"Index {currentIndex} : Value {willsCurrentGrade} : Element {currentElement} : Letter Grade {currentGrade}");
                // Index 0 : Value 10 : Element 1

            }

            double averageGrade = Math.Round((double)totalGrade / willsGrades.Length);
            string letterAverage = GradeCovertor((int)averageGrade);

            Console.WriteLine($"Wills Average Grade is {averageGrade} : {letterAverage}");









        } // Main



        public static void LetterGradeConvertorLoop()
        {

            // -------

            // Nested Conditions
            // Grading Table
            Random rand = new Random();

            for (int i = 0; i < 20; i++)
            {
               string grade = GradeCovertor(rand.Next(40, 106));
            }


        } // Letter Grade Convertor

        public static string GradeCovertor(int grade)
        {
            int numericalGrade = grade;

            // Error > 100
            // A - 90 - 100
            // B - 80 - 89
            // C - 70 - 79
            // D - 60 - 69
            // F - < 60



            Console.Write($"{numericalGrade} - ");
            string letterGrade = "";

            // | 101 ----------------------------------------
            if (numericalGrade > 100)
            {
                letterGrade = "Invalid Input";
            }
            // | 90 -----------A---------- 100
            else if (numericalGrade >= 90)
            {
                numericalGrade -= 90;
                letterGrade = "A";

                if (numericalGrade <= 95)
                {
                    letterGrade += "-";
                }

            }
            else if (numericalGrade >= 80)
            {
                numericalGrade -= 80;
                letterGrade = "B";

                if (numericalGrade > 7)
                {
                    letterGrade += "+";
                }
                else if (numericalGrade <= 3)
                {
                    letterGrade += "-";
                }
            }
            else if (numericalGrade >= 70)
            {
                letterGrade = "C";

                if (numericalGrade > 7)
                {
                    letterGrade += "+";
                }
                else if (numericalGrade <= 3)
                {
                    letterGrade += "-";
                }
            }
            else if (numericalGrade >= 60)
            {
                letterGrade = "D";
                if (numericalGrade > 7)
                {
                    letterGrade += "+";
                }
                else if (numericalGrade <= 3)
                {
                    letterGrade += "-";
                }
            }
            else
            {
                letterGrade = "F";

            }


            //letterGrade = "Grade " + letterGrade;
            Console.WriteLine(letterGrade);

            return letterGrade;
        }

        public static void RandomExample()
        {
            // Introduce the Random Object
            // Type Random
            Random rand = new Random();
            // In order to use our random object, we call the .Next Method
            int randomNumber = rand.Next();
            // Calling Next with a max value ( exclusive )
            int randomNumberMaxValue = rand.Next(101);
            // Calling Next with a min and max value
            int randomNumberMinMax = rand.Next(-50, 51);
        }

    } // class

} // namespace
