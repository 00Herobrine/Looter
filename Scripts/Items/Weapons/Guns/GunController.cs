using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [field: Header("Gun Refs")]
    [field: SerializeField] public GunDefinition Definition { get; private set; }
    [field: Header("Gun Info")]
    [field: SerializeField] public List<GunComponentBehaviour> AttachedComponents { get; private set; }
    [field: SerializeField] public List<GunComponentData> Components { get; private set; }
    public bool IsFunctional() {
        bool functional = false;
        foreach (var component in AttachedComponents)
        {
            //foreach (Definition.CrucialComponents == AttachedComponents.ComponentType) {
                //functional = true;
            //}
        }

        return functional;
    }

    private void Start()
    {
        GetAttachedComponents();
        //Debug.Log($"{Definition.Name} {IsFunctional?} functional? {}");
    }

    void GetAttachedComponents()
    {
        GunComponentBehaviour[] attached = gameObject.GetComponentsInChildren<GunComponentBehaviour>();
        foreach(var comp in attached) AttachedComponents.Add(comp);
    }
}

