using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float movespeed;
    public GameObject gameOverScreen;
    public Text scoretext;
    public Text oyuniçi;
    public static bool protec;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("w") && transform.position.y <5)
        {
            transform.position += Vector3.up * movespeed * Time.deltaTime;
            
        }
        if (Input.GetKey("d" )&& transform.position.x <10 )
        {
            transform.position += Vector3.right * movespeed * Time.deltaTime;

        }
        if (Input.GetKey("a") && transform.position.x > -10)
        {
            transform.position += Vector3.left * movespeed * Time.deltaTime;

        }


        if (Input.GetKey("s") && transform.position.y > -5)
        {
            transform.position += Vector3.down * movespeed * Time.deltaTime;
            

        }
        
        if (protec)
        {
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.yellow);

        }
        else 
        {
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.white);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bullet")&&!protec) 
        {
            gameOver();    
        }
        if (collision.gameObject.CompareTag("protector")) 
        {
            protec = false;
            protec = true;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("area")) 
        {
            gameOver();
        }
    }
    void gameOver() 
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 1 / 30;
        oyuniçi.gameObject.SetActive(false);
    }
}
