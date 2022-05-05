using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBuddy : MonoBehaviour
{
    float times = 3f;

    public GameObject Buddy;
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
            GameObject obj = (GameObject)Instantiate(Buddy);
            int ni = Random.Range(2, 4);
            int nt = Random.Range(-8, -6);
            obj.transform.position = new Vector3(ni, 4, nt);
            times = Random.Range(1, 3);
        }
    }

    
}
