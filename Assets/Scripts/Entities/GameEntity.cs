using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

public abstract class GameEntity : MonoBehaviour, IInteractable, IAttacking, IDamageble, IPointerDownHandler
{
    [Inject] private UIController _controller;

    [Header("Main Info")]
    [SerializeField] private int _id;
    [SerializeField] private string _name;
    [SerializeField] private Sprite _sprite;
    [SerializeField] private int _team;
    [SerializeField] [TextArea] private string _description;
    [Header("Battle Info")]
    [SerializeField] private int _health;
    [SerializeField] private int _damage;
    [SerializeField] private int _defense;
    [SerializeField] private int _range;

    public int Damage { get => _damage; set { } }
    public int Defense { get => _defense; set { } }
    public int Range { get => _range; set { } }
    public int HealthPoints { get => _health; set { } }
    public int ID { get => _id; set { } }
    public int Team { get => _team; set { } }
    public string Name { get => _name; set { } }
    public string Description { get => _description; set { } }
    public Sprite Icon { get => _sprite; set { } }

    public virtual string GetDataString()
    {
        return $"ID:{_id}\nName:{_name}\nTeam:{_team}\nDescription:{_description}\nHealth:{_health}\nDefense:{_defense}\nDamage:{_damage}\nRange:{_range}";
    }

    public void Heal(int amount)
    {
    }

    public void Interact()
    {
        (_controller.Panels[0] as ObservePanel).SetCurrentObject(this);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Interact();
    }

    public void TakeDamage(int amount)
    {
    }
}
