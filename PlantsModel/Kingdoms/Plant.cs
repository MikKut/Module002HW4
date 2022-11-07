using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plants.PlantsModel.Kingdoms
{
    /// <inheritdoc />
    internal abstract class Plant : IPlant
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Plant"/> class.
        /// </summary>
        /// <param name="size">Sets <see cref="Size"/>.</param>
        /// <param name="willBeGrownIn">Sets <see cref="willBeGrownIn">.</param>
        /// <paramref name="id"/>Sets <see cref="ID">.</param>.
        public Plant(int size, DateTime willBeGrownIn, int id)
        {
            this.Size = size;
            this.WillBeGrownIn = willBeGrownIn;
            this.ID = id;
        }

        /// <inheritdoc cref="IPlant.Size"/>
        public int Size { get; private set; }

        /// <inheritdoc cref="IPlant.WillBeGrownIn"/>
        public DateTime WillBeGrownIn { get; private set; }

        /// <inheritdoc cref="IPlant.ID"/>
        public int ID { get; private set; }
    }
}
