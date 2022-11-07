using Plants.Extensions;
using Plants.PlantsModel.Kingdoms;

namespace Plants.GardenersPlot
{
    /// <summary>
    /// Represents plot of the gardener.
    /// </summary>
    internal class Plot
    {
        /// <summary>
        /// Represents max quantity of plants.
        /// </summary>
        public const int MaxQuantityOfPlants = 120;

        private IPlant[] plants;

        /// <summary>
        /// Initializes a new instance of the <see cref="Plot"/> class.
        /// </summary>
        public Plot()
        {
            this.plants = new IPlant[MaxQuantityOfPlants];
        }

        /// <summary>
        /// Gets all plants in the plot.
        /// </summary>
        public IPlant[] Plants
        {
            get => this.plants;
            private set => this.plants = value;
        }

        /// <summary>
        /// Gets current quantity of plants.
        /// </summary>
        public int CurrentQuantityOfPlants { get; private set; }

        /// <summary>
        /// Add plant in the plot.
        /// </summary>
        /// <param name="plant">The plant to be added.</param>
        /// <returns>True if there is no that plant in the plot(looks by id). Otherwise - false.</returns>
        public bool AddPlant(IPlant plant)
        {
            if (this.plants.Length == this.CurrentQuantityOfPlants || this.PlantExists(plant.ID) || plant == null)
            {
                return false;
            }

            this.plants[this.CurrentQuantityOfPlants++] = plant;
            return true;
        }

        /// <summary>
        /// <inheritdoc cref="IPlantArrayExtension.SortById(IPlant[])">.
        /// </summary>
        public void SortPlantsByID()
        {
            this.plants = this.plants.SortById();
        }

        /// <summary>
        /// Finds plant by id or returns null.
        /// </summary>
        /// <param name="id">id you are looking for.</param>
        /// <returns>Plant or null.</returns>
        public IPlant FindPlantByIdOrReturnNull(int id)
        {
            return this.plants.FindPlantById(id);
        }

        private bool PlantExists(int plantId)
        {
            for (int i = 0; i < this.CurrentQuantityOfPlants; i++)
            {
                if (this.plants[i].ID == plantId)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
