using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInstantiator : MonoBehaviour
{
    public GameObject what;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            //Debug.Log("Instantiate!");
            Instantiate(what, transform.position, transform.rotation);
        }
    }
}
