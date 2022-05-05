using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadBuddyFall : MonoBehaviour
{
    //float Speed = -7f;
    public float tumble = 3f;
    //public Rigidbody Buddy_Rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Rigidbody>().velocity = transform.up * Speed;
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider GetObj)
    {
        if (GetObj != null)
            Destroy (gameObject);
    }
}
