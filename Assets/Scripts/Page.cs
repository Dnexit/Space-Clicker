using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Page : MonoBehaviour
{
    
    
    
    public virtual void HideCanvas()
    {
        gameObject.SetActive(false);
        
    }
    
    public virtual void ShowCanvas()
    {
        gameObject.SetActive(true);    
    }
}
