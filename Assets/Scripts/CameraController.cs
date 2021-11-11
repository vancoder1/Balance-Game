using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset;
    void LateUpdate()
    {
        transform.position = playerTransform.position + offset;
    }
}
