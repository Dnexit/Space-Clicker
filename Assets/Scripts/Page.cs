using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page : MonoBehaviour
{
    [SerializeField] private AudioSource sound;
    public virtual void HideCanvas()
    {
        gameObject.SetActive(false);
        
    }
    
    public virtual void ShowCanvas()
    {
        gameObject.SetActive(true);    
    }
    
    public virtual void ShowCanvas(int count)
    {
        gameObject.SetActive(true);    
    }

    public virtual void PlaySoundButton()
    {
        sound.Play();
    }
    
}
