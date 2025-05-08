using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class home : MonoBehaviour
{
    int s=1,mo,buy=5,a;
    public GameObject bu1;
    public Sprite on, off;
    public Text b2;
    public Text b3;
    void Start()
    {
        a = PlayerPrefs.GetInt("a",0);
        mo = PlayerPrefs.GetInt("mo",0);
        b3.text = "Score = "+mo;
    }

    void Update()
    {
        
    }
    public void selectshooter(int a)
    {
        PlayerPrefs.SetInt("a", 0);
        if(buy<=mo)
        {
            print("you can buy");
            PlayerPrefs.SetInt("a", 1);
            mo -= buy;
            PlayerPrefs.Save();
            b2.GetComponent<Text>().text = "Selected";
        }
        else
        {
            print("not enough money");
        }
        
    }
    public void btnplay()
    {
        SceneManager.LoadScene("play");
    }
    public void selectcontrol(int co)
    {
        PlayerPrefs.SetInt("co", co);
    }
    public void btnsound()
    {
        s++;
        if (s % 2 == 0)
        {
            PlayerPrefs.SetInt("s", s);
            bu1.GetComponent<Image>().sprite = on;
        }
        else if (s % 2 == 1)
        {
            PlayerPrefs.SetInt("s", s);
            bu1.GetComponent <Image>().sprite = off;
        }
    }


}
