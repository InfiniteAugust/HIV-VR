using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(call());
    }

    IEnumerator call() {
        yield return new WaitForSeconds(40);
        gameObject.GetComponent<Canvas>().enabled = true; 
        Debug.Log("set to true");
    }
}
