using DotNetGraph.Core;
using DotNetGraph.Node;

namespace DotNetGraph.Attributes
{
	public class DotNodeRankAttribute : IDotAttribute
	{		
		public DotNodeRank Rank { get; set; }
		public DotNodeRankAttribute(DotNodeRank rank = default)
		{
			Rank = rank;
		}

		public static implicit operator DotNodeRankAttribute(DotNodeRank? rank)
		{
			return rank.HasValue ? new DotNodeRankAttribute(rank.Value) : null;
		}
	}
}
