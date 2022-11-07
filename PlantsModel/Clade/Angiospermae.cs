using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plants.PlantsModel.Kingdoms;

namespace Plants.PlantsModel.Clade
{
    /// <summary>
    /// Angiospermae - flowering plants are plants that bear flowers and fruits.
    /// </summary>
    internal abstract class Angiospermae : Plant, IAngiospermae
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Angiospermae"/> class.
        /// </summary>
        /// <param name="size"><inheritdoc cref="Kingdoms.IPlant.Size"/></param>
        /// <param name="willBeGrownIn"><inheritdoc cref="Kingdoms.IPlant.willBeGrownIn"/></param>
        /// <param name="colour"><inheritdoc cref="IAngiospermae.ColourOfTheFlower"/></param>
        /// <param name="id"/><inheritdoc cref="IPlant.ID"/>.</param>.
        public Angiospermae(int size, DateTime willBeGrownIn, System.Drawing.Color colour, int id)
            : base(size, willBeGrownIn, id)
        {
            this.ColourOfTheFlower = colour;
        }

        /// <inheritdoc />
        public System.Drawing.Color ColourOfTheFlower { get; private set; }

        /// <summary>
        /// Gets quantity of embryonic leaves.
        /// </summary>
        public abstract int QuantityOfEmbryonicLeaves { get; }
    }
}
