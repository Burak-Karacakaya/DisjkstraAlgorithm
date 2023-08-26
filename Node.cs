using System;
namespace DisjkstraAlgorithm;

public class Node
{
	public string Name { get; set; }
	public Dictionary<Node, int> Edges { get; set; }

	public Node(string name, Dictionary<Node, int> edges)
	{
		Name = name;
		Edges = edges;
	}

	public Node(string name)
	{
		Name = name;
	}

	public Node AddEdge(Node nodes, int distance)
	{
		Edges ??= new Dictionary<Node, int>();

		Edges.Add(nodes, distance);
		return this;
	}

	public override string ToString() => $"Node : {Name}, Edges : {Edges?.Count}";
}

