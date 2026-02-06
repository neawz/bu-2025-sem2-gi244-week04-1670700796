using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    Camera cam;
    float boundOffset = 10;
    private void Awake()
    {
        cam = FindFirstObjectByType<Camera>();
    }
    void Update()
    {
        if (transform.position.z > Mathf.Clamp(transform.position.z, -(cam.orthographicSize + boundOffset), cam.orthographicSize + boundOffset) || transform.position.z < -10)
        {
            Destroy(gameObject);
        }
    }
}
