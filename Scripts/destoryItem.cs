using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destoryItem : MonoBehaviour
{
    public bool istrigger;
    // Start is called before the first frame update
    void Start()
    {
        istrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetIt()
    {
        istrigger = true;
        this.gameObject.transform.localScale *= 1f;
    }

    public void ReleaseIt()
    {
        istrigger = false;
    }
}
