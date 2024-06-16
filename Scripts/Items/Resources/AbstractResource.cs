using UnityEngine;

public abstract class AbstractResource<T> : AbstractItemBehaviour<T> where T : ResourceData
{

}

public class ResourceData : ItemData
{

}