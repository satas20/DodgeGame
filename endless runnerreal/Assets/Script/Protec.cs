using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protec : MonoBehaviour
{
    public Transform protec;
    // Start is called before the first frame update
    void Start()
    {
        protec.position = new Vector2(Random.Range(-10, 10), Random.Range(-5, 5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
