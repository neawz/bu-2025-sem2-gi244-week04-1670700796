using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;

    public float speed;
    public InputAction moveAction;
    public InputAction shootAction;
    public float xRange = 10;
    public float waitTime = 1f;
    public float reloadTime = 0;

    public GameObject foodPrefab;

    Camera cam;
    private void Awake()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        shootAction = InputSystem.actions.FindAction("Shoot");
        cam = FindFirstObjectByType<Camera>();
        reloadTime = waitTime;
    }

    void Update()
    {
        Vector2 movement = moveAction.ReadValue<Vector2>();
        horizontalInput = movement.x;

        transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -cam.orthographicSize, cam.orthographicSize), transform.position.y, transform.position.z);

        if (shootAction.IsPressed())
        {
            var food = Instantiate(foodPrefab, transform.position, Quaternion.identity);
            Destroy(food, 1f);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        //Gizmos.DrawWireSphere(transform.position, 1);
        //Gizmos.color = Color.green;
        //Gizmos.DrawLine(transform.position, Camera.main.transform.position);
        Gizmos.DrawLine(
            new Vector3(-xRange, transform.position.y, transform.position.z),
            new Vector3(xRange, transform.position.y, transform.position.z));
    }
}
