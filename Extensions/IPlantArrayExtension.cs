using Plants.PlantsModel.Kingdoms;

namespace Plants.Extensions
{
    /// <summary>
    /// Extension class for finding certain plants by criteria.
    /// </summary>
    internal static class IPlantArrayExtension
    {
        /// <summary>
        /// Gets all plants higher than the size.
        /// </summary>
        /// <param name="plants">All plants.</param>
        /// <param name="size">Higher than.</param>
        /// <returns>All the plants that matches the condition.</returns>
        public static IPlant[] GetAllPlantsHigherThan(this IPlant[] plants, int size)
        {
            if (plants == null)
            {
                throw new ArgumentNullException($"{nameof(plants)} is null");
            }

            var allPlants = new IPlant[GetQuantityOfAllPlantsHigherThan(plants, size)];
            int index = 0;
            foreach (var plant in plants)
            {
                if (plant != null && plant.Size > size)
                {
                    allPlants[index++] = plant;
                }
            }

            return allPlants;
        }

        /// <summary>
        /// Sorts plants by ID.
        /// </summary>
        /// <param name="plants">Extends IPlant array.</param>.
        /// <returns>Sorted array.</returns>
        public static IPlant[] SortById(this IPlant[] plants)
        {
            if (plants == null)
            {
                throw new ArgumentNullException($"{nameof(plants)} is null");
            }

            return plants.Where(x => x != null).OrderBy(flower => flower.ID).ToArray();
        }

        /// <summary>
        /// Finds a plant by id or returns null.
        /// </summary>
        /// <param name="plants">Extends IPlant array.</param>
        /// <param name="id">ID you are looking for.</param>
        /// <returns>Plant or null.</returns>
        public static IPlant FindPlantById(this IPlant[] plants, int id)
        {
            if (plants == null)
            {
                throw new ArgumentNullException($"{nameof(plants)} is null");
            }

            foreach (var plant in plants)
            {
                if (plant != null && plant.ID == id)
                {
                    return plant;
                }
            }

            return null;
        }

        private static int GetQuantityOfAllPlantsHigherThan(IPlant[] plants, int size)
        {
            if (plants == null)
            {
                throw new ArgumentNullException($"{nameof(plants)} is null");
            }

            int quantity = 0;
            foreach (var plant in plants)
            {
                if (plant != null && plant.Size > size)
                {
                    quantity++;
                }
            }

            return quantity;
        }
    }
}
