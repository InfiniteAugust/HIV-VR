using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateDeadPlatelet : MonoBehaviour
{
    float times = 3f;
    

    public GameObject DeadPlatelet;
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
            GameObject obj = (GameObject)Instantiate(DeadPlatelet);
            int ni = Random.Range(-14, 22);
            int nt = Random.Range(12, 56);
            obj.transform.position = new Vector3(ni, 20, nt);
            times = Random.Range(0, 2);
        }
    }

    
}