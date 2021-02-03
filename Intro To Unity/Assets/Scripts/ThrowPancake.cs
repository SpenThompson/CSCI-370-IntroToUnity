using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowPancake : MonoBehaviour
{
    public GameObject pancake;

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
        Instantiate(pancake);
    }

    IEnumerator DropPancake2()
    {
        yield return new WaitForSeconds(2f);
        for (; ; )
        {
            Instantiate(pancake);
            yield return new WaitForSeconds(Random.Range(2f, 4f));
        }
    }
}
