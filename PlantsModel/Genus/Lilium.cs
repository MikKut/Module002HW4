using System.Drawing;
using Plants.PlantsModel.Family;

namespace Plants.PlantsModel.Genus
{
    /// <summary>
    /// Lilium is a genus of herbaceous flowering plants growing from bulbs, all with large prominent flowers.
    /// </summary>
    internal class Lilium : Liliaceae, IGenus
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Lilium"/> class.
        /// </summary>
        /// <param name="size"><inheritdoc cref="Kingdoms.IPlant.Size"/></param>
        /// <param name="willBeGrownIn"><inheritdoc cref="Kingdoms.IPlant.willBeGrownIn"/></param>
        /// <param name="colour"><inheritdoc cref="IAngiospermae.ColourOfTheFlower"/></param>
        /// <param name="id"/><inheritdoc cref="IPlant.ID"/>.</param>.
        public Lilium(int size, DateTime willBeGrownIn, Color colour, int id)
            : base(size, willBeGrownIn, colour, id)
        {
        }

        /// <summary>
        /// Gets a genus name.
        /// </summary>
        public string GenusName => "Lilium";
    }
}
