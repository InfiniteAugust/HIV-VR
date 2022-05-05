using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Component : MonoBehaviour
{

    [SerializeField] GameObject I_model, I_mode2, I_mode3, I_mode4, I_mode5;
    GameObject NewI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Camera.main.transform);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RightHand"))
        {
            GetComponent<MeshRenderer>().material.color = Color.green;


            if (gameObject.tag == "I")
            {
                NewI=Instantiate(I_model, transform.position, transform.rotation);
            }
            if (gameObject.tag == "N")
            {
                NewI = Instantiate(I_mode2, transform.position, transform.rotation);
            }
            if (gameObject.tag == "T")
            {
                NewI = Instantiate(I_mode3, transform.position, transform.rotation);
            }
            if (gameObject.tag == "E")
            {
                NewI = Instantiate(I_mode4, transform.position, transform.rotation);
            }
            if (gameObject.tag == "L")
            {
                NewI = Instantiate(I_mode5, transform.position, transform.rotation);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("RightHand"))
        {
            GetComponent<MeshRenderer>().material.color = Color.red;

            if (NewI.GetComponent<destoryItem>().istrigger==false )
            {
                Destroy(NewI);
            }
        }
    }
}
