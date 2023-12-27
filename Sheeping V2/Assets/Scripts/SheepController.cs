using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepController : MonoBehaviour
{
    public Transform centerPoint; // The point around which the object revolves
    public float rotationSpeed = 20f; // Adjust the speed of revolution here

    // Update is called once per frame
    void Update()
    {
        // Ensure there is a center point assigned
        if (centerPoint != null)
        {
            // Orbit around the centerPoint along the Y-axis
            transform.RotateAround(centerPoint.position, Vector3.up, rotationSpeed * Time.deltaTime);
        }
        else
        {
            Debug.LogWarning("Center point not assigned for revolution.");
        }
    }
}
