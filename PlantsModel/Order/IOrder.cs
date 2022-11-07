using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plants.PlantsModel.Order
{
    /// <summary>
    /// Shows the order of the product.
    /// </summary>
    internal interface IOrder
    {
        /// <summary>
        /// Gets an order name.
        /// </summary>
        public string OrderName { get; }
    }
}
