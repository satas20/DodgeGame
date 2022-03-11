using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    public Rigidbody2D bullet;
    public float bulletspeed;
    private Vector2 startvector;
    private Vector2 direction;
    public GameObject player;
    public GameObject bullet1;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 target = player.transform.position;
        int random = (int)Random.Range(0, 4);
        
        if (random == 0)
        {
           
            bullet.transform.position = new Vector3(Random.Range(-11, 11), Random.Range(5, 6), Random.Range(0, 1));
        }
        if (random == 1)
        {
            
            bullet.transform.position = new Vector3(Random.Range(-11, 11), Random.Range(-6, -5), Random.Range(0, 1));
        }
        if (random == 2)
        {
            
            bullet.transform.position = new Vector3(Random.Range(-15, -14), Random.Range(-6, 6), Random.Range(0, 1));
        }
        if (random == 3)
        {
           ;
            bullet.transform.position = new Vector3(Random.Range(14, 15), Random.Range(-6, 6), Random.Range(0, 1));
        }

        player = GameObject.FindGameObjectWithTag("player");
        direction = new Vector2(player.transform.position.x-transform.position.x, player.transform.position.y - transform.position.y).normalized;
        bullet.AddForce(direction*bulletspeed);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
           
            Destroy(gameObject);
            
        }
        else if (collision.gameObject.CompareTag("wall")) 
        {
            Destroy(gameObject);
        }
    }
    

}
