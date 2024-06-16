using UnityEngine;

public class ArmoredRigBehaviour : AbstractItemBehaviour<ArmoredRigData>
{
    [field: SerializeField] public ArmorZone[] ArmorZones;
}

public class ArmoredRigData : ItemData
{

}