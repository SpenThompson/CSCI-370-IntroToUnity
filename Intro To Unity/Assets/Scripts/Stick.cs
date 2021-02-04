using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    //Collider m_Collider;
    
    // Start is called before the first frame update
    void Start()
    {
        //m_Collider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //transform.parent = col.transform;
        Collider m_Collider = GetComponent<Collider>();
        m_Collider.enabled = false;
    }
}
