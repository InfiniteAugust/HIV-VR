using UnityEngine.Audio;
using System;
using UnityEngine;

public class DialogChanger : MonoBehaviour
{
    public Sound[] dialogs;
    // Start is called before the first frame update
    void Awake()
    {
        foreach(Sound d in dialogs) {
            d.source = gameObject.AddComponent<AudioSource>();
            d.source.clip = d.clip;

        }
    }

    public void Play (string name) {
        Sound s = Array.Find(dialogs, dialog => dialog.soundName == name);
        if (s == null) {
            Debug.Log("No such dialog name.");
            return;
        }
        s.source.Play();
        //Debug.Log(name + " is playing");
    }

}
