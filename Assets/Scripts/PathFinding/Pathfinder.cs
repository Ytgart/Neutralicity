using System.Linq;
using System.Collections.Generic;
using System.Numerics;

public class Pathfinder
{
    public List<Vector2> FindPath(Vector2 startPosition, Vector2 targetPosition, Dictionary<Vector2, float> weightMatrix, out List<Vector2> path)
    {
        var checkedTiles = new List<Node>();
        var waitingTiles = new List<Node>();
        var startNode = new Node(0, weightMatrix[startPosition], startPosition, targetPosition, null);

        checkedTiles.Add(startNode);

        waitingTiles.AddRange(FindNeighbourTiles(startNode, weightMatrix));

        while (waitingTiles.Count > 0)
        {
            Node nodeToCheck = waitingTiles.Where(x => x.F == waitingTiles.Min(y => y.F)).Last();

            if (nodeToCheck.Position == targetPosition)
            {
                return path = CalculatePathFromTiles(nodeToCheck);
            }

            waitingTiles.Remove(nodeToCheck);
            if (!checkedTiles.Where(x => x.Position == nodeToCheck.Position).Any())
            {
                checkedTiles.Add(nodeToCheck);
                waitingTiles.AddRange(FindNeighbourTiles(nodeToCheck, weightMatrix));
            }
        }
        return path = null;
    }

    private List<Vector2> CalculatePathFromTiles(Node data)
    {
        var resultPath = new List<Vector2>();
        var currentNode = data;

        while (currentNode.PreviousNode != null)
        {
            resultPath.Add(currentNode.Position);
            currentNode = currentNode.PreviousNode;
        }
        return resultPath;
    }

    private List<Node> FindNeighbourTiles(Node node, Dictionary<Vector2, float> weightMatrix)
    {
        var neighbours = new List<Node>();

        var coords = new List<Vector2>();

        coords.Add(new Vector2(node.Position.X + 1, node.Position.Y));
        coords.Add(new Vector2(node.Position.X - 1, node.Position.Y));
        coords.Add(new Vector2(node.Position.X, node.Position.Y + 1));
        coords.Add(new Vector2(node.Position.X, node.Position.Y - 1));
        coords.Add(new Vector2(node.Position.X + 1, node.Position.Y + 1));
        coords.Add(new Vector2(node.Position.X - 1, node.Position.Y + 1));
        coords.Add(new Vector2(node.Position.X + 1, node.Position.Y - 1));
        coords.Add(new Vector2(node.Position.X - 1, node.Position.Y - 1));

        for (int i = 0; i < coords.Count; i++)
        {
            if (i > 3)
            {
                neighbours.Add(new Node(node.G + 1.4f, weightMatrix[coords[i]], coords[i], node.TargetPosition, node));
            }
            neighbours.Add(new Node(node.G + 1f, weightMatrix[coords[i]], coords[i], node.TargetPosition, node));
        }
        return neighbours;
    }
}
