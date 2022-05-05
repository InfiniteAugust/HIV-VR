using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogScene1 : MonoBehaviour {
    DialogChanger dc;
    //public GameObject guideCanvas;
    public GameObject mentor;
    private GameObject virus;
    private bool ended;

    private void Start() {
        dc = FindObjectOfType<DialogChanger>();
        virus = GameObject.Find("Virus");
        //Debug.Log(virus);
        StartCoroutine(playSeq());
        ended = true;
    }
/*    private void OnTriggerEnter(Collider other) {
        if (other.tag == "mono0") {
            dc.Play("mentor0");
            Debug.Log("mono0 collision triggered.");
        }
    }*/

    private void Update() {
        if (virus.GetComponent<MeshRenderer>().enabled == false) {
            //Debug.Log("disabled in dc!!");
            if(ended == true) {
                dc.Play("narration0");
                ended = false;
            }
            mentor.transform.position -= Vector3.forward* Time.deltaTime* 2;
        }
    }

    IEnumerator playSeq() {
        dc.Play("mentor0");
        yield return new WaitForSeconds(dc.dialogs[0].clip.length + 11);
        dc.Play("mentor1");
        yield return new WaitForSeconds(dc.dialogs[1].clip.length);
/*
        guideCanvas.SetActive(true);
        GetComponent<WalkInPlaceLocomotion>().enabled = true;*/
    }


    /*    private void onTriggerEnter(Collision collision) {
             if (collision.collider.tag == "mono0") {
                FindObjectOfType<DialogChanger>().Play("player0");
                Debug.Log("player collision triggered.");
            } 

        }*/
}
