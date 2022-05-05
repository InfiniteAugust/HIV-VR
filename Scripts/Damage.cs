using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damageAmount = 1;

    //	void OnTriggerEnter(Collider collision) {
    //		if (damageOnTrigger) {
    //			// if the hit object has the Health script on it, deal damage
    //			if (collision.gameObject.GetComponent<Health>() != null) {  
    //				collision.gameObject.GetComponent<Health>().ApplyDamage(damageAmount);
    //			}
    //		}
    //	}

    //	void OnCollisionEnter(Collision collision)  
    //{
    //		if (damageOnCollision) {
    //			if (collision.gameObject.GetComponent<Health>() != null) {  
    //				collision.gameObject.GetComponent<Health>().ApplyDamage(damageAmount);
    //			}
    //		}
    //	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("I")|| other.CompareTag("T") || other.CompareTag("E") || other.CompareTag("L") || other.CompareTag("N"))
        {

            if(other.gameObject.GetComponent<destoryItem>() != null)
            {
                gameObject.GetComponent<Health>().ApplyDamage(damageAmount);
                if (other.tag != "Player") 
                    Destroy(other.gameObject);
                }
            }
    }
}
