using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public GameObject[] prefabcoins;
    int mo;
    void Start()
    {
        InvokeRepeating("coinses",5f,8f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void coinses()
    {
        int r=Random.Range(0,prefabcoins.Length);
        Vector2 posx = new Vector2(Random.Range(-2.5f, 2.5f), transform.position.y);
        Instantiate(prefabcoins[r],posx, Quaternion.identity);
        PlayerPrefs.SetInt("mo",mo);
    }
}
