using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (pos.x < transform.position.x && transform.localScale.x < 0 || pos.x > transform.position.x && transform.localScale.x > 0) {
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }

        transform.position = new Vector2(pos.x, transform.position.y);
    }
}
