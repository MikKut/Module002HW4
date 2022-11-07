using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plants.PlantsModel.Species
{
    /// <summary>
    /// Shows the spiece of the product and its full name.
    /// </summary>
    internal interface ISpiece
    {
        /// <summary>
        /// Gets spiece name.
        /// </summary>
        public string SpieceName { get; }

        /// <summary>
        /// Gets full name of the spiece.
        /// </summary>
        public string FullName { get; } // There won't always be the same domains, so the implementation is undefined
    }
}
