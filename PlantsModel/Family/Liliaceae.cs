using System.Drawing;
using Plants.PlantsModel.Clade;
using Plants.PlantsModel.Order;

namespace Plants.PlantsModel.Family
{
    /// <summary>
    /// The lily family, Liliaceae, consists of about 15 genera and 610 species of flowering plants within the order Liliales. They are monocotyledonous, perennial, herbaceous, often bulbous geophytes.
    /// </summary>
    internal class Liliaceae : Liliales, IFamily
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Liliaceae"/> class.
        /// </summary>
        /// <param name="size"><inheritdoc cref="Kingdoms.IPlant.Size"/></param>
        /// <param name="willBeGrownIn"><inheritdoc cref="Kingdoms.IPlant.willBeGrownIn"/></param>
        /// <param name="colour"><inheritdoc cref="IAngiospermae.ColourOfTheFlower"/></param>
        /// <param name="id"/><inheritdoc cref="IPlant.ID"/>.</param>.
        public Liliaceae(int size, DateTime willBeGrownIn, Color colour, int id)
            : base(size, willBeGrownIn, colour, id)
        {
        }

        /// <inheritdoc cref="IFamily.FamilyName"/>
        public string FamilyName => "Liliales";
    }
}
