using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateDeadBuddy : MonoBehaviour
{
    float times = 3f;
    

    public GameObject DeadBuddy;
    GameObject targert = null; 
    
    // Start is called before the first frame update
    void Start()
    {
        //Buddy_Rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {

        times -= Time.deltaTime;  
        //Buddy_Rigidbody.velocity = transform.forward * Speed;
        if (times < 0)  
        {       
            GameObject obj = (GameObject)Instantiate(DeadBuddy);
            int ni = Random.Range(-12, 20);
            int nt = Random.Range(12, 56);
            obj.transform.position = new Vector3(ni, 20, nt);
            times = Random.Range(1, 2);
        }
    }

    
}