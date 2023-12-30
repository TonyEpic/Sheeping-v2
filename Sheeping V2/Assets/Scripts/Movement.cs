using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Speed of movement
    public float rotateSpeed = 120.0f; // Speed of rotation
    public float jumpForce = 8.0f; // Force applied for jumping
    private bool isGrounded;

    void Update()
    {
        // Movement based on WASD keys
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        // Rotate the object horizontally based on mouse movement (left and right)
        float mouseX = Input.GetAxis("Mouse X");
        float horizontalRotation = mouseX * rotateSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, horizontalRotation);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("oafioewbfioesfoinf");
        // Check if the object is grounded upon collision with a surface tagged as "Ground"
        isGrounded = true;
    }
}
