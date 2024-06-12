using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    // [SerializeField] private GameObject doodle;
    // float diff = 1.929999f;

    // // Update is called once per frame
    // void Update()
    // {
    //     transform.position = new Vector3(transform.position.x, doodle.transform.position.y - diff, -10);
    // }

    public Transform target;

 

    // Update is called once per frame
    void LateUpdate()
    {
        if (target.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
            //transform.position = Vector3.SmoothDamp(transform.position, newPos, ref currentVelocity, smoothSpeed * Time.deltaTime);
            transform.position = newPos;    

        }
    }
}


