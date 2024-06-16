public interface IHealth
{
    float Health { get; }
}

public interface IMaxHealth : IHealth
{
    float MaxHealth { get; }
}