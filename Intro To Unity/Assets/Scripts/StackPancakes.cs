using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackPancakes : MonoBehaviour
{
    public GameObject pancake;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        GameObject newPancake = Instantiate(pancake, transform.position, transform.rotation);//, col.transform);
        newPancake.transform.parent = col.transform;
        Destroy(gameObject);
    }
}
