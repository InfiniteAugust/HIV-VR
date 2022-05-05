using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogAfter : MonoBehaviour {
    DialogChanger dc;
    public GameObject text;

    private void Start() {
        dc = FindObjectOfType<DialogChanger>();
        StartCoroutine(playSeq());
    }
/*    private void OnTriggerEnter(Collider other) {
        if (other.tag == "mono0") {
            StartCoroutine(playSeq());
            Debug.Log("after scene collision triggered.");
        }

    }*/

    IEnumerator playSeq() {
        GetComponent<WalkInPlaceLocomotion>().enabled = false;
        
        dc.Play("man0");
        yield return new WaitForSeconds(dc.dialogs[0].clip.length);
        dc.Play("player");
        yield return new WaitForSeconds(dc.dialogs[1].clip.length);

        //GetComponent<WalkInPlaceLocomotion>().enabled = true;

        text.SetActive(true);
        
    }

}
