using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{  
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0); 
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerCotrollerScript;
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnObstacle", startDelay, repeatRate); 
       playerCotrollerScript = GameObject.Find("Player").GetComponent<PlayerController>(); 
    }

    void SpawnObstacle()
    {
      if (playerCotrollerScript.gameOver == false)
      {
           Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);  
      }
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
