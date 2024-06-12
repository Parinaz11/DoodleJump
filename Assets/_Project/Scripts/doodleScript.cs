using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doodleScript : MonoBehaviour
{

    [SerializeField] float amount = 0.1f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A)){
            // Getkey difference with GetKeyDown -> the key has to go down and it doesn't matter if it isn't up
            Debug.Log("A");
            transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y);
        }
        // if (Input.GetMouseButtonDown(0)){
        //     Vector2 cleckedPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //     Debug.Log(clockedPosition);

        //     // visual1.setActive(false);
        //     // visual2.setActive(true);
        // }
        if (Input.GetKeyUp(KeyCode.D)){
            Debug.Log("D");
            transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y);
        }
    }
}
