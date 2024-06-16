using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class Exhaust : MonoBehaviour
{
    [field: SerializeField] public ParticleSystem ExhaustParticle { get; private set; }
    [field: SerializeField] public Transform[] ExhaustLocation { get; private set; }
    public void Start()
    {
        ExhaustParticle.Play();
    }

    public void Stop()
    {
        ExhaustParticle.Stop();
    }
}