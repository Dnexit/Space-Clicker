using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsCanvas : Page
{
    [SerializeField] private Button BackButton;
    [SerializeField] private Switch switchMusic;
    [SerializeField] private Switch switchSound;
    [SerializeField] private AudioMixer audioMixer;
    
    private Page lastPage;

    private void Awake()
    {
        BackButton.onClick.AddListener((() =>
        {
            PlaySoundButton();
            HideCanvas();
            lastPage.ShowCanvas();
        }));
        
        switchMusic.OnDisable.AddListener((() =>
        {
            PlaySoundButton();
            audioMixer.SetFloat("MusicVolume", -80f);
        }));
        
        switchMusic.OnEnable.AddListener((() =>
        {
            PlaySoundButton();
            audioMixer.SetFloat("MusicVolume", 0f);
        }));
        
        switchSound.OnDisable.AddListener((() =>
        {
            PlaySoundButton();
            audioMixer.SetFloat("SoundVolume", -80f);
        }));
        
        switchSound.OnEnable.AddListener((() =>
        {
            PlaySoundButton();
            audioMixer.SetFloat("SoundVolume", 0f);
        }));
        
    }

    public void HideCanvas()
    {
        base.HideCanvas();
    }

    public void ShowCanvas(Page page)
    {
        lastPage = page;
        base.ShowCanvas();
    }
}