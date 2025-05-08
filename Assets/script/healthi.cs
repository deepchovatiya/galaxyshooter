using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthi : MonoBehaviour
{
    public GameObject[] helath;
    void Start()
    {
        InvokeRepeating("prefabhealth", 5f, 10f);
    }

    void Update()
    {
        
    }
    public void prefabhealth()
    {
        int r = Random.Range(0, helath.Length);
        Vector2 posX = new Vector2(Random.Range(-2.5f, 2.5f), transform.position.y);
        Instantiate(helath[r],posX, Quaternion.identity);
    }
}
