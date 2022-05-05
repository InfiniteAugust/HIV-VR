using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogScene0 : MonoBehaviour
{
    DialogChanger dc;
    public GameObject guideCanvas;

    private void Start() {
        dc = FindObjectOfType<DialogChanger>();
        StartCoroutine(playSeq());
    }
    private void OnTriggerEnter(Collider other) {
        if (other.tag == "mono0") {
               dc.Play("mentor0");
            Debug.Log("mono0 collision triggered.");
        }

       
    }

    IEnumerator playSeq() {
        dc.Play("player0");
        yield return new WaitForSeconds(dc.dialogs[0].clip.length);
        dc.Play("narration0");
        yield return new WaitForSeconds(dc.dialogs[1].clip.length);
        dc.Play("player1");
        yield return new WaitForSeconds(dc.dialogs[2].clip.length);
        dc.Play("narration1");
        yield return new WaitForSeconds(dc.dialogs[3].clip.length);
        guideCanvas.SetActive(true);
        GetComponent<WalkInPlaceLocomotion>().enabled = true;
    }


    /*    private void onTriggerEnter(Collision collision) {
             if (collision.collider.tag == "mono0") {
                FindObjectOfType<DialogChanger>().Play("player0");
                Debug.Log("player collision triggered.");
            } 

        }*/
}
