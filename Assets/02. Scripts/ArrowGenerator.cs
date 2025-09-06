using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    
    public GameObject arrowPrefab;
    public float spawnTime = 1.0f;
    float deltaTime = 0f;


    void Update()
    {
        deltaTime += Time.deltaTime;
        if (deltaTime > spawnTime)
        {
            if (GameDirector.gameOver == false)
            { 
                deltaTime = 0f;
                GameObject go = Instantiate(arrowPrefab);
                float px = Random.Range(-8f, 8f);
                go.transform.position = new Vector3(px, 6, 0);
            } 
        }
    }
}
