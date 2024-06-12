// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class originalSpringPrefab : MonoBehaviour
// {
//     // Start is called before the first frame update
//     [SerializeField] private GameObject springPlatformPrefab;
//     private int numberOfPlatforms = 1;
//     private float levelWidth = 7f;
//     private float minY = 5f;
//     private float maxY = 6.5f;
//     private float elapsedTime = 0f;
//     private float time = elapsedTime;

//     void Update()
//     {

//         if (elapsedTime - time > 3000){
//             Vector3 spawnPosition2 = new Vector3();

//             for (int i = 0; i < numberOfPlatforms; i++)
//             {
//                 spawnPosition2.y += Random.Range(minY, maxY);
//                 spawnPosition2.x = Random.Range(-levelWidth, levelWidth);
//                 Instantiate(springPlatformPrefab, spawnPosition2, Quaternion.identity);
//             }
//             time = elapsedTime;
//         }
//         elapsedTime++;
        
//     }
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class originalSpringPrefab : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public GameObject platformPrefab;
    public int numberOfPlatforms = 20;
    public float levelWidth = 7f;
    public float minY = 5.2f;
    public float maxY = 6.5f;

    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
