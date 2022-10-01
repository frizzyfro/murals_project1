using System;
using static System.Console;

namespace ProgrammingAssignment1 // Faye Struble  801193047
{
    class MarshallsRevenue
    {
        static void Main()
        {
            WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM"); // write lines to display make your vision your view
            WriteLine("M  Make your vision your view.  M");
            WriteLine("MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
            Write("Enter number of interior murals scheduled >> "); // prompt user to input number of interior murals
            double interior_murals = Convert.ToDouble(ReadLine());
            Write("Enter number of exterior murals scheduled >> "); // prompt user to input number of exterior murals
            double exterior_murals = Convert.ToDouble(ReadLine());
            const double per_interior = 500; // define cost of interior murals per
            const double per_exterior = 750; // define cost of exterior murals per
            double total_interior = interior_murals * per_interior; // multiply # of murals scheduled times cost 
            double total_exterior = exterior_murals * per_exterior;
            WriteLine("{0} interior murals are scheduled at {1} each for a total of {2}", interior_murals, per_interior.ToString("C"), total_interior.ToString("C")); // output scheduled murals, price per mural and total cost of interior
            WriteLine("{0} exterior murals are scheduled at {1} each for a total of {2}", exterior_murals, per_exterior.ToString("C"), total_exterior.ToString("C")); // output scheduled murals, price per mural and total cost of exterior
            double total_revenue = total_exterior + total_interior; // add quantities to get total revenue
            WriteLine("Total revenue expected is {0}", total_revenue.ToString("C")); //output revenue in a string
            bool greater_scheduled = interior_murals > exterior_murals; // bool to calculate if interior murals is greater than exterior
            WriteLine("It is {0} that there are more interior murals scheduled than exterior ones.", greater_scheduled); // output bool within string 
            Read();
        }
    }
}
