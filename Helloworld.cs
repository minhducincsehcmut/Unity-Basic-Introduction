using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helloworld : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    void Start()
    {
        Debug.Log("HelloWorld");
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
        // Add a force of 2000 on the z-axis
    }
}
