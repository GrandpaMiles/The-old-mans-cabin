using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class r : MonoBehaviour
{
    Rigidbody myRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            myRigidBody.AddForce(new Vector3(10, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            myRigidBody.AddForce(new Vector3(-10, 0, 0));
        }
    }
}
