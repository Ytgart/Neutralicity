public enum InteractableType
{
    city,
    unit,
    structure
}

public interface IInteractable
{
    int Index { get; set; }
    InteractableType Type { get; set; }
}
