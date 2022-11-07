namespace Plants.PlantsModel.Kingdoms
{
    /// <summary>
    /// Base interface for all products.
    /// </summary>
    internal interface IPlant
    {
        /// <summary>
        /// Gets size of the plant.
        /// </summary>
        public int Size { get; }

        /// <summary>
        /// Gets the time when the plant is old enough to sell.
        /// </summary>
        public DateTime WillBeGrownIn { get; }

        /// <summary>
        /// Gets ID of the plant.
        /// </summary>
        public int ID { get; }
    }
}