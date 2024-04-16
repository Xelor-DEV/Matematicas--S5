using UnityEngine;
public class CoordinateSystemController : MonoBehaviour
{
    [SerializeField] private float gizmoLength;
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(Vector3.zero, Vector3.right * gizmoLength);
        Gizmos.DrawLine(Vector3.zero, Vector3.left * gizmoLength);

        Gizmos.color = Color.green;
        Gizmos.DrawLine(Vector3.zero, Vector3.up * gizmoLength);
        Gizmos.DrawLine(Vector3.zero, Vector3.down * gizmoLength);

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(Vector3.zero, Vector3.forward * gizmoLength);
        Gizmos.DrawLine(Vector3.zero, Vector3.back* gizmoLength);
    }
}
