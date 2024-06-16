using System;
using System.Threading.Tasks;

[Serializable]
public class AbilityEffectBurn : AbilityEffect
{
    public int Amount;
    public override Task Apply(Character character)
    {
        return Task.CompletedTask;
    }
}