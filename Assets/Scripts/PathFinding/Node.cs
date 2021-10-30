using System;
using System.Numerics;

public class Node
{
    public Vector2 Position { get; set; }
    public Vector2 TargetPosition { get; set; }
    public Node PreviousNode { get; set; }
    public float F { get; set; } = 0;
    public float G { get; set; } = 0;
    public float H { get; set; } = 0;

    public Node(float g, float modifier, Vector2 position, Vector2 targetPosition, Node previousNode)
    {
        G = g;
        Position = position;
        TargetPosition = targetPosition;
        PreviousNode = previousNode;
        H = Math.Abs(targetPosition.X - position.X) + Math.Abs(targetPosition.Y - position.Y);
        F = g + H + modifier;
    }
}
