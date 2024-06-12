using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    [SerializeField] private GameObject doodle;
    float diff = 1.929999f;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, doodle.transform.position.y - diff, -10);
    }
}
