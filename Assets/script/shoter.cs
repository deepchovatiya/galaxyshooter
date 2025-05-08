using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class shoter : MonoBehaviour
{
    float speed = 0.1f;
    public GameObject[] prefabbulet;
    public Transform pos;
    public Sprite[] shoters;
    int a,co,s;
    bool isleft=false,isright=false;
    public GameObject b1, b2;
    new AudioSource audio;
    public AudioClip clip1, clip2;
    public Slider slider;
    int health=10;
    public int mo=0;
    public Text l;

    void Start()
    {
        mo = PlayerPrefs.GetInt("mo", 1);
        co=PlayerPrefs.GetInt("co",0);
        InvokeRepeating("prefabbu",0.2f,0.2f);
        GetComponent<SpriteRenderer>().sprite = shoters[a];
        s = PlayerPrefs.GetInt("s",0);
        audio = GetComponent<AudioSource>();
        slider.value = health;
        l.text = "Score = "+mo;
       
    }

    void Update()
    {
        if(co==0)
        {
            key();
        }
        if(co==1)
        {
            b1.SetActive(true);
            b2.SetActive(true);
            if (isleft == true)
            {
                leftrotate();
            }
            if (isright == true)
            {
                rightrotate();
            }
        }
        if(co==2)
        {
            accelaration();
        }
        if(co==3)
        {
            touching();
        }
        if(transform.position.z!=90)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0),speed);
        }
    }
    void key()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            float posX = Mathf.Clamp(transform.position.x - speed, -2.5f, 2.5f);
            transform.position = new Vector2(posX,transform.position.y);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            float posX = Mathf.Clamp(transform.position.x + speed, -2.5f, 2.5f);
            transform.position = new Vector2(posX, transform.position.y);

        }
        b1.SetActive(false);
        b2.SetActive(false);
       
    }
    public void btndownleft()
    {
        isleft = true;
        if (s % 2 == 0)
        {
            audio.clip = clip1;
            audio.Play();
        }
        else
        {
            audio.volume = 0;
        }
    }
    public void btnupleft()
    {
        isleft = false;
    }
    public void leftrotate()
    {
        float posX = Mathf.Clamp(transform.position.x - speed, -2.5f, 2.5f);
        transform.position = new Vector2(posX, transform.position.y);
    }
    public void btnrightdown()
    {
        isright = true;
        if (s % 2 == 0)
        {
            audio.clip = clip1;
            audio.Play();
        }
        else
        {
            audio.volume = 0;
        }
    }
    public void btnrightup()
    {
        isright = false;
    }
    public void rightrotate()
    {
        float posX = Mathf.Clamp(transform.position.x + speed, -2.5f, 2.5f);
        transform.position = new Vector2(posX, transform.position.y);
    }
    public void prefabbu()
    {
        int r = Random.Range(0, prefabbulet.Length);
        Instantiate(prefabbulet[r], pos.position, Quaternion.identity);
    }
  
    void accelaration()
    { 
        if(Input.acceleration.x<-0.1f)
        {
            leftrotate();
        }
        if(Input.acceleration.x<0.1f)
        {
            rightrotate();
        }
        b1.SetActive(false);
        b2.SetActive(false);
    }
    void touching()
    {
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            if (t.position.x < Screen.width / 2)
            {
                leftrotate();
            }
            if (t.position.x > Screen.width / 2)
            {
                rightrotate();
            }

        }
        b1.SetActive(false);
        b2.SetActive(false);
    }
    public void btnsetting()
    {
        SceneManager.LoadScene("setting");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            audio.clip = clip2;
            audio.Play();
            slider.value = slider.value - 1;
            if(slider.value==0)
            {
                SceneManager.LoadScene("loss");
            }
        }
        if(collision.gameObject.tag=="heal")
        {
            Destroy(collision.gameObject);
            slider.value = slider.value + 1;
        }
        if(collision.gameObject.tag =="coins")
        {
            PlayerPrefs.SetInt("mo",mo++);
            PlayerPrefs.Save();
            l.text = "Score = "+mo;
            Destroy(collision.gameObject);
           
        }
    }
    }
