using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class SoundManager : MonoBehaviour
{
    public AudioSource soundEffect;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlaySound(AudioClip clip)
    {
        soundEffect.PlayOneShot(clip);
    }
}
