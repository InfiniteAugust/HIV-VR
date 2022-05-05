using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuddyDestroy : MonoBehaviour
{
    float Speed = 3f;
    //public Rigidbody Buddy_Rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * Speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void OnTriggerEnter(Collider GetObj)
    {
        if (GetObj != null)
            Destroy (gameObject);
    }*/
}
