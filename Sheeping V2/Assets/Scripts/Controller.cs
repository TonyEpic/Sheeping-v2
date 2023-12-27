using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float force = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");

        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddTorque(-Vector3.forward * x * force);
        rigidbody.AddTorque(Vector3.right * y * force);
    }
}
