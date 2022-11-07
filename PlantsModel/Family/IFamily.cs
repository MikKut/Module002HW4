using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plants.PlantsModel.Family
{
    /// <summary>
    /// Shows that this is a family.
    /// </summary>
    internal interface IFamily
    {
        /// <summary>
        /// Gets family name.
        /// </summary>
        public string FamilyName { get; }
    }
}
