using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (GameDirector.gameOver == false)
            {
                transform.Translate(-moveSpeed, 0, 0);
            }
        }
        
            
        

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (GameDirector.gameOver == false)
            {
                transform.Translate(moveSpeed, 0, 0);
            }
                
        }
    }
}
