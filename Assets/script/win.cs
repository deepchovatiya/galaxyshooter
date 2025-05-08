using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class win : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void btnnext()
    {
        SceneManager.LoadScene("play");
    }
    public void btnset()
    {
        SceneManager.LoadScene("setting");
    }
}
