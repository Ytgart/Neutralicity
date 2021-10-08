public interface IDamageable 
{
    int HealthPoints{get; set;}

    void TakeDamage(int damageAmount);
}