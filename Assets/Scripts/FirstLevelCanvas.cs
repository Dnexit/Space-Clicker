using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstLevelCanvas : Page
{
     [SerializeField] private Button settingsButton;

     private void Awake()
     {
         settingsButton.onClick.AddListener(() =>
         {
             
         });
     }
}
