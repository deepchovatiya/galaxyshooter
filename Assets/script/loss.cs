using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loss : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void btncontinue()
    {
        SceneManager.LoadScene("play");
    }
    public void btnsetting()
    {
        SceneManager.LoadScene("setting");
    }
}
