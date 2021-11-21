using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformprefab;
    public int platformcount = 300;
    
    void Start()
    {
        Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < platformcount; i++)
        {
            spawnPosition.y += Random.Range(.5f, 2f);
            spawnPosition.x = Random.Range(-5f, 5f);
            Instantiate(platformprefab, spawnPosition, Quaternion.identity);
            

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
