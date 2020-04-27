using System;
using System.Collections.Generic;
using System.Text;
using DotNetGraph.Core;

namespace DotNetGraph.Attributes
{
	public class DotEdgeLHeadAttribute : IDotAttribute
	{
		public string LHead { get; set; }

		public DotEdgeLHeadAttribute(string lhead = default)
		{
			LHead = lhead;
		}

		public static implicit operator DotEdgeLHeadAttribute(string lhead)
		{
			return string.IsNullOrEmpty(lhead) ? null : new DotEdgeLHeadAttribute(lhead);
		}
	}
}
