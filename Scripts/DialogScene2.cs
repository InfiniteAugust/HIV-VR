using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogScene2 : MonoBehaviour {
    DialogChanger dc;
    //public GameObject guideCanvas;

    private void Start() {
        dc = FindObjectOfType<DialogChanger>();
        StartCoroutine(playSeq());
    }
/*    private void OnTriggerEnter(Collider other) {
        if (other.tag == "mono0") {
            dc.Play("mentor0");
            Debug.Log("mono0 collision triggered.");
        }
    }*/

    IEnumerator playSeq() {
        dc.Play("mentor0");
        yield return new WaitForSeconds(dc.dialogs[0].clip.length +38);
        dc.Play("mentor1");
        yield return new WaitForSeconds(dc.dialogs[1].clip.length);

        //guideCanvas.SetActive(true);
        //GetComponent<WalkInPlaceLocomotion>().enabled = true;
    }

}