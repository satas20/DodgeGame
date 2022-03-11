using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public GameObject bullet;
    public Text timer;
    private float time;
    public float cooldown;
    private float cooldown2 = 0;
    public GameObject player;
    private GameObject bulletpref;
    public static int score=0;
    public  float proteccooldown;
    private float proteccooldown1;
    public float proteccooldownspawn;
    private float proteccooldownspawn1=0;
    public GameObject protec;
    public GameObject topleft;
    public GameObject bottomright;
    public GameObject topright;
    public GameObject bottomleft;
    public float areaTriger;
    private float areatimer=2;
    public GameObject topleftfire;
    private bool topleftactive=false;
    public GameObject bottomrightfire;
    private bool bottomrightactive = false;
    public GameObject toprightfire;
    private bool toprightactive = false;
    public GameObject bottomleftfire;
    private bool bottomleftactive = false;
    void Start()
    {
        Time.timeScale = 1;
        proteccooldown1 = proteccooldown;
        proteccooldownspawn1 = proteccooldownspawn;
    }

    // Update is called once per frame
    void Update()
    {
        bulletpref = bullet;
        time += Time.deltaTime;
        score =(int) time;
        cooldown2 += Time.deltaTime;
        if (cooldown2>cooldown) 
        {
            Instantiate(bulletpref);
           
            cooldown2 = 0;

        }
        proteccooldownspawn1 -= Time.deltaTime;
        
        if (proteccooldownspawn1 <0)
        {
            Instantiate(protec);
            Debug.Log("spawned");
            proteccooldownspawn1 = proteccooldownspawn;
        }
        if (Player.protec) 
        {
            proteccooldown1 -= Time.deltaTime;
        }
        if (proteccooldown1 < 0) 
        {
            proteccooldown1 = proteccooldown;
            Player.protec = false;
        }
        timer.text= (""+(int)time);
        score = (int)time;
        areatimer += Time.deltaTime;
        if (areatimer > 5) 
        {
            topleftfire.SetActive(false);
            topleft.GetComponent<Renderer>().material.SetColor("_Color", Color.grey);
            bottomright.GetComponent<Renderer>().material.SetColor("_Color", Color.grey);
            topleft.GetComponent<BoxCollider2D>().enabled = false;
            bottomright.GetComponent<BoxCollider2D>().enabled = false;
            bottomright.SetActive(false);
            topleft.SetActive(false);
            topright.GetComponent<Renderer>().material.SetColor("_Color", Color.grey);
            bottomleft.GetComponent<Renderer>().material.SetColor("_Color", Color.grey);
            topright.GetComponent<BoxCollider2D>().enabled = false;
            bottomleft.GetComponent<BoxCollider2D>().enabled = false;
            bottomleft.SetActive(false);
            topright.SetActive(false);
            topleftactive = false;
            bottomrightactive = false;
            bottomleftactive = false;
            toprightactive = false;
            



            int rand = Random.Range(0, 4); 
            if (rand == 1)
            {
                topleft.gameObject.SetActive(true);
                topleftactive = true;
            }
            else if(rand==0)
            {
                bottomright.SetActive(true);
                bottomrightactive = true;

            }
            else if (rand == 2)
            {
                bottomleft.SetActive(true);
                bottomleftactive = true;
            }
            else if (rand == 3)
            {
                topleft.SetActive(true);
                topleftactive = true;

            }

            areaTriger = 2;
            areatimer = 0;
        }
        if (areaTriger > 0)
        {
            
            areaTriger -= Time.deltaTime;
           
        }
        else if(areaTriger<0)
        {
            topleft.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            bottomright.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            topleft.GetComponent<BoxCollider2D>().enabled = true;
            bottomright.GetComponent<BoxCollider2D>().enabled = true;
            topright.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            bottomleft.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            topright.GetComponent<BoxCollider2D>().enabled = true;
            bottomleft.GetComponent<BoxCollider2D>().enabled = true;
            if (topleftactive) 
            {

                topleftfire.SetActive(true);
            }
            if (bottomrightactive)
            {

                bottomrightfire.SetActive(true);
            }
            if (toprightactive)
            {

                topleftfire.SetActive(true);
            }
            if (bottomleftactive)
            {

                bottomleftfire.SetActive(true);
            }

        }
    }
}
