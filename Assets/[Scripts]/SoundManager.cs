using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
[System.Serializable]
public class SoundManager : MonoBehaviour
{
    AudioMixer mixer;
    public AudioSource soundEffect;
    private List<AudioClip> clipList;
    void Awake()
    {
        soundEffect = GetComponent<AudioSource>();
        clipList = new List<AudioClip>();
        CreateList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CreateList()
    {
        clipList.Add(Resources.Load<AudioClip>("Audio/dash"));
        clipList.Add(Resources.Load<AudioClip>("Audio/attack"));
        clipList.Add(Resources.Load<AudioClip>("Audio/death"));
        mixer = Resources.Load<AudioMixer>("Audio/Master");
    }
    public void PlaySound(SoundFX sound)
    {
        soundEffect.clip = clipList[(int)sound];
        soundEffect.Play();
    }
    public void ChangeMasterVolume(float volume)
    {
        mixer.SetFloat("Master", volume);
    }
    public void ChangeSoundFXVolume(float volume)
    {
        mixer.SetFloat("Sound", volume);
    }
   
}
