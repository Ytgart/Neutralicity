public interface IDamageble
{
    int HealthPoints { get; set; }
    void TakeDamage(int amount);
    void Heal(int amount);
}
