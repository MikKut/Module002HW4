using Plants.Extensions;
using Plants.GardenersPlot;
using Plants.PlantsModel.Kingdoms;
using Plants.PlantsModel.Species;

namespace Plants
{
    /// <summary>
    /// Class with entry point.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point. Testing the program.
        /// </summary>
        public static void Main()
        {
            var plotOfTheGardener = new Plot();
            AddSomePlants(plotOfTheGardener);
            TestSorting(plotOfTheGardener);
            TestFinding(plotOfTheGardener);
        }

        private static void DisplayPlants(Plot plot)
        {
            for (int i = 0; i < plot.CurrentQuantityOfPlants; i++)
            {
                Console.WriteLine(plot.Plants[i].ID);
            }
        }

        private static void TestFinding(Plot plot)
        {
            Console.WriteLine($"{plot.FindPlantByIdOrReturnNull(2)} has 2 id");
            var handredId = plot.FindPlantByIdOrReturnNull(100);
            Console.WriteLine($"There is some plants with 100 ID: {handredId != null}");
        }

        private static void TestSorting(Plot plot)
        {
            Console.WriteLine("Before sorting");
            DisplayPlants(plot);
            plot.SortPlantsByID();
            Console.WriteLine("After sorting");
            DisplayPlants(plot);
        }

        private static void AddSomePlants(Plot plot)
        {
            int id = 0;
            plot.AddPlant(new Arboricola(10, new DateTime(1, 10, 2), System.Drawing.Color.Pink, id++));
            plot.AddPlant(new Arboricola(20, new DateTime(1, 5, 6), System.Drawing.Color.Pink, 2));
            id++;
            plot.AddPlant(new Arboricola(5, new DateTime(1, 6, 5), System.Drawing.Color.Pink, 1));
            id++;
            plot.AddPlant(new Candidum(10, new DateTime(1, 7, 3), System.Drawing.Color.AntiqueWhite, id++));
            plot.AddPlant(new Candidum(24, new DateTime(1, 2, 10), System.Drawing.Color.AntiqueWhite, id++));
        }
    }
}