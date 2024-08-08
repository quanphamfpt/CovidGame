using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
   public static SoundManager instance {  get; private set; }

    public AudioSource music;
    public AudioSource SFX;

    public AudioClip mainTheme;
    public AudioClip gameOverSfx;
    public AudioClip hitItemSFX;
    public AudioClip shootSFX;
    public AudioClip destroyObstacleSFX;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        PlayeMusic(mainTheme);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayeMusic(AudioClip clip)
    {
        music.clip = clip;
        music.Play();
    }

    public void PlayeSFX(AudioClip clip)
    {
        SFX.PlayOneShot(clip);
    }
}
