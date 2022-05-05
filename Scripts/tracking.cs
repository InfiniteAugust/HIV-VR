using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tracking : MonoBehaviour
{
    public Transform UIFollow;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, UIFollow.transform.position, step);
        transform.LookAt(Camera.main.transform.position);
    }
}
