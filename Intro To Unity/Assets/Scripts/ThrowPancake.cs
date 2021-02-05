using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowPancake : MonoBehaviour
{
    public GameObject pancake;
    public GameObject bird;
    public GameObject score;
    public GameObject bear;
    
    public GameObject previewBird;
    public GameObject previewPancake;

    private GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.Find("Canvas");
        //previewPancake = GameObject.Find("Pancake");
        //previewBird = GameObject.Find("Bird");
        
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
                Instantiate(pancake, new Vector2(Random.Range(-7.0f, 7.0f), 6.5f), pancake.transform.rotation);
            }
            else
            {
                Instantiate(bird, new Vector2(Random.Range(-6.8f, 6.8f), 6.5f), bird.transform.rotation);
            }
            
            yield return new WaitForSeconds(Random.Range(2f, 4f));
        }
    }

    public void Play() {
        canvas.SetActive(false);
        previewBird.SetActive(false);
        //previewPancake.SetActive(false);
        bear.GetComponent<FollowMouse>().enabled = true;
        StartCoroutine("DropPancake");
    }

    public void incScore(int i) {
        //score += i;
    }
}
