using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody player_rb;
    private bool _isGrounded;
    public float mvmntSpeed = 150.0f;

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
        float mH = Input.GetAxis("Horizontal");
        float mV = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(mH, 0, mV);
        player_rb.AddForce(movement * mvmntSpeed);
    }
}
