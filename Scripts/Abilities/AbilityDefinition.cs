using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Ability")]
public class AbilityDefinition : ScriptableObject
{
    [SerializeReference, SubclassSelector] public List<AbilityEffect> Effects;
    public double Cooldown = 1f;
}