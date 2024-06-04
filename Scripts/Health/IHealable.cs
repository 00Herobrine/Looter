public interface IHealable : IHealth
{
    float MaxHealth { get; }
    void Heal(float amount);
}