using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFootsteps : MonoBehaviour
{
    public AudioClip[] clips;
    private AudioSource audiosource;

    private void Awake()
    {
        audiosource = GetComponent<AudioSource>();
    }

    private void PlayerStep()
    {
        AudioClip clip = GetRandomAudioClip();
        audiosource.PlayOneShot(clip);
    }

    private AudioClip GetRandomAudioClip()
    {
        return clips[UnityEngine.Random.Range(0, clips.Length)];
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
