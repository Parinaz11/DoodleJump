using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenPlatformPrefab : MonoBehaviour
{

    [SerializeField] private GameObject greenPlatform;
    [SerializeField] private float elapsedTime;
    [SerializeField] private float spawnTime = 0.05f;

    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > spawnTime) {
            float randomY = Random.Range(0.1f, 2.5f);
            float randomX = Random.Range(-2, 3);
            transform.position = new Vector3(transform.position.x + randomX, transform.position.y + randomY);
            GameObject newGreenPlatform = Instantiate(greenPlatform, transform.position, Quaternion.identity); // Meaning no rotation changes involved for the third parameter
            elapsedTime = 0;
        }
    }
}
