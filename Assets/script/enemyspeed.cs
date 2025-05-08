using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspeed : MonoBehaviour
{
    float speed = 0.05f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - speed); 
        if(transform.position.y<-6)
        {
            Destroy(gameObject);
        }
    }
}
