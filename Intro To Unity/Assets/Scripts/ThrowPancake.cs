using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowPancake : MonoBehaviour
{
    public GameObject pancake;
    public GameObject bird;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DropPancake");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DropPancake()
    {
        yield return new WaitForSeconds(2f);
        for (; ; )
        {
            int randint = Random.Range(0, 4);
            if (randint == 0 || randint == 1)
            {
                Instantiate(pancake, new Vector2(Random.Range(-9.5f, 9.5f), 6.5f), pancake.transform.rotation);
            }
            else
            {
                Instantiate(bird, new Vector2(Random.Range(-9.5f, 9.5f), 6.5f), bird.transform.rotation);
            }
            
            yield return new WaitForSeconds(Random.Range(2f, 4f));
        }
    }
}
