using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Phase2Change : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Timer", 60f);
    }

    // Update is called once per frame
    public void Timer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
