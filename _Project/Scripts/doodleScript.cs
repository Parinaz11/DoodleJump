using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doodleScript : MonoBehaviour
{

    [SerializeField] private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A)){
            // Getkey difference with GetKeyDown -> the key has to go down and it doesn't matter if it isn't up
            Debug.Log("A");
            transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y);
        }
        if (Input.GetKeyUp(KeyCode.D)){
            Debug.Log("D");
            transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y);
        }
    }
}
