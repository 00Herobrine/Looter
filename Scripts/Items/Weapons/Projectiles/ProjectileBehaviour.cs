using UnityEngine;

[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Rigidbody))]
public class ProjectileBehaviour : AbstractItemBehaviour<Projectile>
{
    [field: Header("Projectile Refs")]
    [field: SerializeField] public Rigidbody Rigidbody { get; private set; }
    public Vector3 Velocity { get; private set; }
    public ProjectileAttribute[] Attributes { get; private set; }
    public LineRenderer LineRenderer { get; set; }

    private void Start()
    {
        ApplyAttributes();
    }

    public void ApplyAttributes()
    {
        foreach(ProjectileAttribute attribute in Attributes)
            attribute.ApplyAttribute(this);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(IsServer)
            foreach(var attribute in Attributes)
            {
                attribute.OnProjectileCollision(this, collision);
            }
        TriggerImpactEffect(collision.GetContact(0));
    }


    //[ClientRpc]
    private void TriggerImpactEffect(ContactPoint contactPoint)
    {
        foreach (var attribute in Attributes)
        {
            attribute.ApplyImpactEffect(this, contactPoint);
        }
    }

}