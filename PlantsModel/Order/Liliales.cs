using System.Drawing;
using Plants.PlantsModel.Clade;

namespace Plants.PlantsModel.Order
{
    /// <summary>
    /// Lilium is a genus of herbaceous flowering plants growing from bulbs, all with large prominent flowers.
    /// </summary>
    internal abstract class Liliales : Monocotyledones, IOrder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Liliales"/> class.
        /// </summary>
        /// <param name="size"><inheritdoc cref="Kingdoms.IPlant.Size"/></param>
        /// <param name="willBeGrownIn"><inheritdoc cref="Kingdoms.IPlant.willBeGrownIn"/></param>
        /// <param name="colour"><inheritdoc cref="IAngiospermae.ColourOfTheFlower"/></param>
        /// <param name="id"/><inheritdoc cref="IPlant.ID"/>.</param>.
        public Liliales(int size, DateTime willBeGrownIn, Color colour, int id)
            : base(size, willBeGrownIn, colour, id)
        {
        }

        /// <inheritdoc cref="IOrder.OrderName">
        public string OrderName => "Liliales";
    }
}
