using UnityEngine;

public class GizmoWorkAround : MonoBehaviour
{
    public GameObject line;
    private void OnStart()
    {
        line.SetActive(false);
    }
}
