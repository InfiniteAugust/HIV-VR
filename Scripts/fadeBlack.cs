using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fadeBlack : MonoBehaviour
{
    private float t = 0f;
    private float t1 = 0f;
    public bool Towhite;
    // Start is called before the first frame update
    void Start()
    {
        Towhite = true;
    }

    // Update is called once per frame
    void Update()

    {   
        if(Towhite)
        //Towhite
        { 
            if(t<=1)
        t += 0.45f * Time.deltaTime;
        
        }

        if (!Towhite)
        //Toblack
        { 
        t -= 0.45f * Time.deltaTime;

            if (t <0.02f)
            {
                Invoke("Change", 3f);
            }
        }

        GetComponent<MeshRenderer>().material.SetFloat("_trans", Mathf.Lerp(-0.5f, 1f, t));
    }  

    public void Change()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
