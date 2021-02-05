using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchPancake : MonoBehaviour
{
    private Rigidbody2D rb;
    //private bool readyToDestroy;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (readyToDestroy) && transform.position>
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //GameObject newPancake = Instantiate(pancake, transform.position, transform.rotation);//, col.transform);
        
        if (col.gameObject.tag == "Pancake") {
            col.transform.parent = transform;
            //readyToDestroy = true;
            
        }

        rb.AddForce(new Vector2(0.5f, 1.0f) * 100);
        Destroy(gameObject, 2.0f);
        //GameManager.Instance.IncScore(-1);
    }
}
