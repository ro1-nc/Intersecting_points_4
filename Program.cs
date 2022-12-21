using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersection_of_points
{
    class Program
    {

        public class Intersection
        {
            public double[] s1 = new double[2];
            public double[] e1 = new double[2];

            public static string Intersection_of_lines(double[] s1, double[] e1, double[] s2, double[] e2)
            {
                //standard form coefficinets

                double A1 = e1[1] - s1[1];
                double B1 = -(e1[0] - s1[0]);
                double C1 = -(s1[0] * e1[1] - s1[1] * e1[0]);

                //standard form coefficinets

                double A2 = e2[1] - s2[1];
                double B2 = -(e2[0] - s2[0]);
                double C2 = -(s2[0] * e2[1] - s2[1] * e2[0]);

                double determinant = A1 * B2 - A2 * B1;
                if (determinant == 0)
                {
                    return "Lines are parallel";
                }
                else
                {
                    double x = (C2 * B1-C1 * B2) / determinant;
                    double y = (A2 * C1-A1 * C2) / determinant;

                    return "Point of Intersection is " + x + "," + y;
                }

            }
        }
        static void Main(string[] args)
        {
            double[] startpt1 = new double[2]{ 0,1 };
            double[] endpt1 = new double[2]{ 0,4 };
            double[] startpt2 = new double[2] { 1,8 };
            double[] endpt2 = new double[2]{ 1,4 };
            Console.WriteLine("Enter start point of 1st line");
            for (int i = 0; i < 2; i++)
            {
                startpt1[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Enter end point of 1st line");
            for (int i = 0; i < 2; i++)
            {
                endpt1[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Enter start point of 2nd line");
            for (int i = 0; i < 2; i++)
            {
                startpt2[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Enter end point of 2nd line");
            for (int i = 0; i < 2; i++)
            {
                endpt2[i] = Convert.ToDouble(Console.ReadLine());
            }

            


            string result = Intersection.Intersection_of_lines(startpt1, endpt1, startpt2, endpt2);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
