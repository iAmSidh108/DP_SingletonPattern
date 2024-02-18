using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientAudioPlayerBehaviour : MonoBehaviour
{
    public static AmbientAudioPlayerBehaviour instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    public void FadeNewMusic(AudioClip clip)
    {
        // TODO
    }

}
