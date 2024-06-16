using UnityEngine;

public class Engine : MonoBehaviour
{
    [field: SerializeField] public EngineDefinition EngineDefinition { get; private set; }
    [field: SerializeField] public Exhaust[] Exhaust { get; private set; }
    [field: SerializeField] public float RPM { get; private set; }
    [field: SerializeField] public float WantedRPM { get; private set; }
    
    public void PlayEffect()
    {
        foreach(Exhaust exhaust in Exhaust)
            exhaust.Start();
    }

    public void StopEffect()
    {
        foreach (Exhaust exhaust in Exhaust)
            exhaust.Stop();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
