using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Plants.PlantsModel.Clade
{
    /// <summary>
    /// Monocotyledons are grass and grass-like flowering plants (angiosperms), the seeds of which typically contain only one embryonic leaf, or cotyledon.
    /// </summary>
    internal abstract class Monocotyledones : Angiospermae
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Monocotyledones"/> class.
        /// </summary>
        /// <param name="size"><inheritdoc cref="Kingdoms.IPlant.Size"/></param>
        /// <param name="willBeGrownIn"><inheritdoc cref="Kingdoms.IPlant.willBeGrownIn"/></param>
        /// <param name="colour"><inheritdoc cref="IAngiospermae.ColourOfTheFlower"/></param>
        /// <param name="id"/><inheritdoc cref="IPlant.ID"/>.</param>.
        public Monocotyledones(int size, DateTime willBeGrownIn, Color colour, int id)
            : base(size, willBeGrownIn, colour, id)
        {
        }

        /// <summary>
        /// Gets quantity of embrionic leaves.
        /// </summary>
        public override int QuantityOfEmbryonicLeaves => 1;
    }
}
