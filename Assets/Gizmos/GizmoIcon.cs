using UnityEngine;
using System.Collections;

public class GizmoIcon : MonoBehaviour
{
    void OnDrawGizmos()
    {
        // Draw the icon at the object's position
        Gizmos.DrawIcon(transform.position, "Basic Line Curve.png", true);
    }
}
