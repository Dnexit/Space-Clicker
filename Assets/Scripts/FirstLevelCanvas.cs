using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FirstLevelCanvas : Page
{
     [SerializeField] private Button settingsButton;
     [SerializeField] private SettingsCanvas _settingsCanvas;
     [SerializeField] private SecondlevelGameCanvas secondLevelGameCanvas;
     [SerializeField] private Button mainButton;
     [SerializeField] private TextMeshProUGUI scoreText;
     [SerializeField] private string scoreBaseText = "SCORE: ";
     [SerializeField] private string scoreFunText;
     [SerializeField] private StarAnimationCanvas starAnimationCanvas;
     
     private int count = 0;
     

     private void Awake()
     {
         settingsButton.onClick.AddListener(() =>
         {
             PlaySoundButton();
             this.HideCanvas();
             _settingsCanvas.ShowCanvas(this);
         });

         mainButton.onClick.AddListener(() =>
         {
             count++;
             scoreText.text = scoreBaseText + count;
             if (count == 30)
             {
                 starAnimationCanvas.ShowCanvas(secondLevelGameCanvas, count);
                 this.HideCanvas();
             }
         });
     }
}
