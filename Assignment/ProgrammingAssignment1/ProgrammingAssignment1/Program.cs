using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Getting inputs. 
            PrintWelcome();
            var x1 = PromtsAndGetValue("Input X coordinate of First Point :- ");
            var y1 = PromtsAndGetValue("Input Y coordinate of First Point :- ");
            var x2 = PromtsAndGetValue("Input X coordinate of Second Point :- ");
            var y2 = PromtsAndGetValue("Input Y coordinate of Second Point :- ");

            // Calculation.
            var deltaX = x2 - x1;
            var deltaY = y2 - y1;
            var sumDeltaSqr = Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2);
            var distance = Math.Sqrt(sumDeltaSqr);
            var radians = Math.Atan2(deltaX, deltaY);
            var angle = radians * (180 / Math.PI);

            // Printing the results, distance and angle.
            Console.WriteLine("Distance between points ({0},{1}) and({2},{3}) is " + distance.ToString("F3", CultureInfo.InvariantCulture), x1, y1, x2, y2);
            Console.WriteLine("Angle (in degrees) between points ({0},{1}) and({2},{3}) is " + angle.ToString("F3", CultureInfo.InvariantCulture), x1, y1, x2, y2);

            // Random input to wait and not exit immediately.
            var input = Console.ReadLine();
        }

        /// <summary>
        /// Prints the welcome message.
        /// </summary>
        public static void PrintWelcome()
        {
            Console.WriteLine("Hello, Welcome");
            Console.WriteLine("This application will calculate the distance between two points and the angle between those points.");
        }

        /// <summary>
        /// Prompts the message and get value.
        /// </summary>
        /// <param name="printMessage">The print message.</param>
        /// <returns></returns>
        public static float PromtsAndGetValue(string printMessage)
        {
            Console.Write(printMessage);
            var input = Console.ReadLine();
            float value;
            if (float.TryParse(input, out value))
            {
                return value;
            }
            return 0;
        }
    }
}
