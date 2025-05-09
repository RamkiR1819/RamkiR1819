using UnityEngine;

public class FlyingController : MonoBehaviour
{
    public float flightSpeed = 10f;
    public float climbSpeed = 5f;
    public float turnSpeed = 2f;
    private float verticalInput;
    private float horizontalInput;

    void Update()
    {
        HandleFlightControls();
    }

    private void HandleFlightControls()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // Move the spaceship forward and backward
        transform.Translate(Vector3.forward * flightSpeed * Time.deltaTime * verticalInput);

        // Climb and descend
        transform.Translate(Vector3.up * climbSpeed * Time.deltaTime * Input.GetAxis("Jump"));

        // Rotate the spaceship
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput);
    }
}