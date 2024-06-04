using UnityEngine;

public class TracerAttribute : ProjectileAttribute
{
    [field: Header("Tracer Attribute")]
    [field: SerializeField] public UnityEngine.Material Material { get; private set; }
    [field: SerializeField] public Color Color { get; private set; }
    public float Length { get; private set; }
    public override void ApplyAttribute(ProjectileBehaviour projectile)
    {
        LineRenderer lineRenderer = projectile.gameObject.AddComponent<LineRenderer>();
        lineRenderer.positionCount = 2;
        lineRenderer.startWidth = 0.05f;
        lineRenderer.endWidth = 0.05f;
        lineRenderer.material = Material;
        lineRenderer.material.color = Color;
        projectile.LineRenderer = lineRenderer;
    }
}