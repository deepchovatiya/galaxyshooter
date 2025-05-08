using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buletrotate : MonoBehaviour
{
    float speed = 0.2f;
    public int damage=2;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + speed);
        if(transform.position.y>5)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="enemy")
        {
            Destroy(collision.gameObject);
        }
    }
}
