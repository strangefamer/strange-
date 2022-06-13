using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    private bool mbPause = false;
    public AudioMixer mixer;
    [SerializeField] Button mPauseBtn;
    public Slider mVolumeSlider;
    void Start()
    {
        //mPauseBtn.onClick.AddListener(GamePause);
        //mVolumeSlider.onValueChanged.AddListener(GameVolumeChange);
    }
    public void GamePause()
    {
        if(!mbPause)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }

        mbPause = !mbPause;

        Debug.Log("button clicked...");
    }
    public void GameVolumeChange(float fVolunme)
    {
        mixer.SetFloat("MaeterVlume", fVolunme);
        Debug.Log(fVolunme);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
