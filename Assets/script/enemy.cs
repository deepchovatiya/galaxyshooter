using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class enemy : MonoBehaviour
{
    public  GameObject[] prefaben;
    void Start()
    {
        InvokeRepeating("prefabenemy", 1f, 1.5f);
    }

    void Update()
    {
        
    }
    public  void prefabenemy()
    {
        int r=Random.Range(0, prefaben.Length);
        Vector2 posX=new Vector2(Random.Range(-2.5f,2.5f),transform.position.y);
        Instantiate(prefaben[r], posX, Quaternion.identity);
    }
   
    
}
