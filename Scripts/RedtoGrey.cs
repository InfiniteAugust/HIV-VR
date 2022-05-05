using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedtoGrey : MonoBehaviour
{
    [ColorUsageAttribute(true, true)] [SerializeField]
    public Color red_A, red_B, this_A, this_B;
    
    public float t = 0;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material.SetColor("_baseColorA", red_A);
        GetComponent<MeshRenderer>().material.SetColor("_baseColorB", red_B);
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime*0.15f;
        GetComponent<MeshRenderer>().material.SetColor("_baseColorA", Color.Lerp(red_A, this_A, t));
        GetComponent<MeshRenderer>().material.SetColor("_baseColorB", Color.Lerp(red_B, this_B, t));
    }
}
