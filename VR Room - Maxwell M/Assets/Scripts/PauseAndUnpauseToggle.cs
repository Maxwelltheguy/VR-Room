using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAndUnpauseToggle : MonoBehaviour
{
    private AudioSource source;

    public void toggle()
    {
        source = GetComponent<AudioSource>();

        if (source.isPlaying == true)
        {
            source.Pause();
        }
        else
        {
            source.UnPause();
        }
    }
}
