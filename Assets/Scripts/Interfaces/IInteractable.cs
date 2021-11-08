public enum InteractableType
{
    city,
    unit,
    structure
}

public interface IInteractable
{
    string Name { get; set; }
    int ID { get; set; }
    InteractableType Type { get; set; }
}
