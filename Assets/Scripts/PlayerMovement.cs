using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody player_rb;
    public Camera main_cam;
    public float mvmntSpeed;

    void Start()
    {
        player_rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        Movement();
    }
    private void Movement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        player_rb.AddForce(movement * mvmntSpeed);
    }
}
