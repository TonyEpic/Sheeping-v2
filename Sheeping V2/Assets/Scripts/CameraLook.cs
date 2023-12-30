using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{

    public float verticalRotateSpeed = 80.0f; // Speed of vertical rotation
    public float verticalRotationLimit = 40.0f; // Limit for vertical rotation

    private float verticalRotation = 0.0f; // Current vertical rotation angle

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y");
        float rawVerticalRotation = -mouseY * verticalRotateSpeed * Time.deltaTime; // Inverted for natural movement

        // Accumulate the vertical rotation
        verticalRotation += rawVerticalRotation;
        verticalRotation = Mathf.Clamp(verticalRotation, -verticalRotationLimit, verticalRotationLimit);

        // Apply the clamped vertical rotation
        transform.localRotation = Quaternion.Euler(verticalRotation, transform.localEulerAngles.y, 0.0f);
    }
}
