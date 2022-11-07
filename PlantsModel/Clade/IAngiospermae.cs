namespace Plants.PlantsModel.Clade
{
    /// <summary>
    /// Angiospermae - flowering plants are plants that bear flowers and fruits.
    /// </summary>
    internal interface IAngiospermae
    {
        /// <summary>
        /// Gets color of the flower.
        /// </summary>
        public System.Drawing.Color ColourOfTheFlower { get; }
    }
}