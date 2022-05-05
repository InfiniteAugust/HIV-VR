using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusMovement : MonoBehaviour
{
    private float timeToChangeDirection = 5f;
    public GameObject playerRef;
    public float speed;
    public bool isAttack;

    // Use this for initialization
    public void Start() {
        ChangeDirection();
    }

    // Update is called once per frame
    public void Update() {
        timeToChangeDirection -= Time.deltaTime;

        if (timeToChangeDirection <= 0) {
            ChangeDirection();
        }

        GetComponent<Rigidbody>().velocity = transform.up * 2;

        if (isAttack)
            transform.position = Vector3.MoveTowards(transform.position, playerRef.transform.position, speed * Time.deltaTime);
        else if (Vector3.Distance(gameObject.transform.position, playerRef.transform.position) < 10) 
            transform.position = Vector3.MoveTowards(transform.position, playerRef.transform.position, speed * Time.deltaTime);
        
    }

    private void ChangeDirection() {
        float angle = Random.Range(0f, 360f);
        Quaternion quat = Quaternion.AngleAxis(angle, Vector3.forward);
        Vector3 newUp = quat * Vector3.up;
        newUp.z = 0;
        newUp.Normalize();
        transform.up = newUp;
        //timeToChangeDirection = 1.5f;
    }
}
