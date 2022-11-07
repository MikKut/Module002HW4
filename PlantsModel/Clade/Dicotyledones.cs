using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plants.PlantsModel.Clade
{
    /// <summary>
    /// The name refers to one of the typical characteristics of the group: namely, that the seed has two embryonic leaves or cotyledons.
    /// </summary>
    internal abstract class Dicotyledones : Angiospermae
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dicotyledones"/> class.
        /// </summary>
        /// <param name="size"><inheritdoc cref="Kingdoms.IPlant.Size"/></param>
        /// <param name="willBeGrownIn"><inheritdoc cref="Kingdoms.IPlant.willBeGrownIn"/></param>
        /// <param name="colour"><inheritdoc cref="IAngiospermae.ColourOfTheFlower"/></param>
        /// <param name="id"/><inheritdoc cref="IPlant.ID"/>.</param>
        /// <param name="economic"><see cref="Economic"/>.</param>.
        public Dicotyledones(int size, DateTime willBeGrownIn, Color colour, bool economic, int id)
            : base(size, willBeGrownIn, colour, id)
        {
            this.Economic = economic;
        }

        /// <summary>
        /// Gets a value indicating whether the plant is economic plant or not.
        /// </summary>
        public bool Economic { get; private set; }

        /// <summary>
        /// Gets quantity of embrionic leaves.
        /// </summary>
        public override int QuantityOfEmbryonicLeaves => 2;
    }
}
