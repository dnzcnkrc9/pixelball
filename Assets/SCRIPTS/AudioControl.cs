using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public AudioSource audioSrc;
    public GameObject soundOnButton;
    public GameObject soundOffButton;
    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SoundOff()
    {
        audioSrc.volume = 0.0f;
        PlayerPrefs.SetFloat("audiovolume", 0.0f);
        soundOnButton.SetActive(true);
    }
    public void SoundOn()
    {
        audioSrc.volume = 1f;
        PlayerPrefs.SetFloat("audiovolume", 1f);
        soundOffButton.SetActive(true);
    }

}
