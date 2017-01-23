using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Vertex
    {
        /// <summary>
        /// Gets or sets a value indicating whether the vertex was visited.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the vertex was visited; otherwise, <c>false</c>.
        /// </value>
        public bool wasVisited { get; set; }

        /// <summary>
        /// Gets or sets the label (description) of the Vertex.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        public string label { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vertex"/> class.
        /// </summary>
        /// <param name="label">The label of the vertex.</param>
        public Vertex(string label)
        {
            this.label = label;
            wasVisited = false;
        }

        /// <summary>
        /// Standard ToString override to display the label of the vertex.
        /// </summary>
        /// <returns>
        /// The label.
        /// </returns>
        public override string ToString()
        {
            return label;
        }
    }
}
