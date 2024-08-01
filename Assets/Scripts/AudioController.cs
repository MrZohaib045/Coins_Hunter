using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AudioController : MonoBehaviour
{
    public static AudioController bgmusic;
    [SerializeField] Slider volumeslider;
    [SerializeField] Image sound_on;
    [SerializeField] Image sound_off;
    private bool muted = false;
    // Start is called before the first frame update
    void Start()
    {
        sound_on.enabled = true;
        sound_off.enabled = false;

        if (!PlayerPrefs.HasKey("Music"))
        {
            PlayerPrefs.SetFloat("Music", 1);
            load();
        }
        else
        {
            load();
        }
        //updatebutton();
        AudioListener.pause = muted;
    }
    // Update is called once per frame
    private void load()
    {
        volumeslider.value = PlayerPrefs.GetFloat("Music");
    }

    public void changevolume()
    {
        AudioListener.volume = volumeslider.value;
        save();
    }

    private void save()
    {
        PlayerPrefs.SetFloat("Music", volumeslider.value);
    }

    private void Awake()
    {
        if(bgmusic == null)
        {
            bgmusic = this;
            DontDestroyOnLoad(bgmusic);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void onpressbutton()
    {
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = true;
            sound_off.enabled = true;
            sound_on.enabled = false;
        }
        else
        {
            muted = false;
            AudioListener.pause = false;
            sound_on.enabled = true;
            sound_off.enabled = false;
        }
        save();
    }
}
