using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsCanvas : Page
{
    [SerializeField] private Button BackButton;
    [SerializeField] private FirstLevelCanvas firstLevelCanvas;

    private void Awake()
    {
        BackButton.onClick.AddListener((() =>
        {
            HideCanvas();
            firstLevelCanvas.ShowCanvas();
        }));
    }


    public override void HideCanvas()
    {
        base.HideCanvas();
    }

    public override void ShowCanvas()
    {
        base.ShowCanvas();
    }
}