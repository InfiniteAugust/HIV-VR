using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeOut : MonoBehaviour
{
    private float t=0f;
    private bool Dis = false;
    // Start is called before the first frame update
    void Start()
    {
        Dis = false;
        Invoke("SetDis", 15f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Dis)
        {
            t += 0.2f*Time.deltaTime;
            GetComponent<MeshRenderer>().material.SetFloat("_dissolve", Mathf.Lerp(1.1f,-0.3f, t));

            Invoke("SceneChange", 10f);
        }

    }

    public void SetDis()
    {
        Dis = true;
    }

    public void SceneChange()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
