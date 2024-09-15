using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class TankTrack : MonoBehaviour
{
    public Transform[] wheels;
    public Transform[] trackPoints; // Track points should be placed around the wheels
    public float trackWidth = 0.5f;
    public float trackHeight = 0.1f;

    private Mesh trackMesh;
    private MeshFilter meshFilter;

    void Start()
    {
        meshFilter = GetComponent<MeshFilter>();
        trackMesh = new Mesh();
        meshFilter.mesh = trackMesh;
        UpdateTrackMesh();
    }

    void Update()
    {
        UpdateTrackPoints();
        UpdateTrackMesh();
    }

    void UpdateTrackPoints()
    {
        // Adjust track points based on terrain
        for (int i = 0; i < trackPoints.Length; i++)
        {
            Ray ray = new Ray(trackPoints[i].position + Vector3.up, Vector3.down);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                trackPoints[i].position = hit.point + Vector3.up * trackHeight;
            }
        }
    }

    void UpdateTrackMesh()
    {
        int vertexCount = trackPoints.Length * 2;
        Vector3[] vertices = new Vector3[vertexCount];
        Vector2[] uvs = new Vector2[vertexCount];
        int quadCount = trackPoints.Length;
        int[] triangles = new int[quadCount * 6];

        for (int i = 0; i < trackPoints.Length; i++)
        {
            Transform point = trackPoints[i];
            Vector3 forward = Vector3.Cross(Vector3.up, point.right);
            vertices[i * 2] = point.position + forward * trackWidth / 2;
            vertices[i * 2 + 1] = point.position - forward * trackWidth / 2;

            float uvY = (float)i / trackPoints.Length;
            uvs[i * 2] = new Vector2(0, uvY);
            uvs[i * 2 + 1] = new Vector2(1, uvY);
        }

        for (int i = 0; i < trackPoints.Length; i++)
        {
            int currentIndex = i * 2;
            int nextIndex = ((i + 1) % trackPoints.Length) * 2;

            triangles[i * 6] = currentIndex;
            triangles[i * 6 + 1] = nextIndex;
            triangles[i * 6 + 2] = currentIndex + 1;

            triangles[i * 6 + 3] = currentIndex + 1;
            triangles[i * 6 + 4] = nextIndex;
            triangles[i * 6 + 5] = nextIndex + 1;
        }

        trackMesh.Clear();
        trackMesh.vertices = vertices;
        trackMesh.triangles = triangles;
        trackMesh.uv = uvs;
        trackMesh.RecalculateNormals();
    }
}