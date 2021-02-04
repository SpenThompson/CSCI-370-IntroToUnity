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
        StartCoroutine("DropPancake2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DropPancake()
    {
        
    }

    IEnumerator DropPancake2()
    {
        yield return new WaitForSeconds(2f);
        for (; ; )
        {
            if (Random.Range(0, 2) == 0)
            {
                Instantiate(pancake, new Vector2(Random.Range(-10.5f, 10.5f), 6.5f), pancake.transform.rotation);
            }
            else
            {
                Instantiate(bird, new Vector2(Random.Range(-9.5f, 9.5f), 6.5f), bird.transform.rotation);
            }
            //Instantiate(pancake);
            yield return new WaitForSeconds(Random.Range(2f, 4f));
        }
    }
}
