using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    public AudioSource Audio;
    public AudioClip CoughAudio1;
    public AudioClip CoughAudio2;
    // Start is called before the first frame update
    void Start()
    {
        PlayAudio();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAudio()
    {
        int a = Random.Range(0, 3);
        if (a == 0)
        {
            Audio.clip = CoughAudio1;
            Audio.Play();
        }
        else if (a==1)
        {
            Audio.clip = CoughAudio2;
            Audio.Play();
        }


        Invoke("PlayAudio", 5f);
    }

}
