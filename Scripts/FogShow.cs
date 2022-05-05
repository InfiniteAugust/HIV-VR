using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogShow : MonoBehaviour
{
    private bool Show = false;
    private float t = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("InceT", 20f);
        GetComponent<MeshRenderer>().material.SetFloat("_fog", 0f);
    }

    // Update is called once per frame
    void Update()
    {

        if (Show)
        {
        t += Time.deltaTime/5;
        GetComponent<MeshRenderer>().material.SetFloat("_fog", Mathf.Lerp(0f, 0.3f, t));
        }
    }

    public void InceT()
    {
        Show = true;
    }
}
