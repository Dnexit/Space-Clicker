using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WinCanvas : Page
{
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button backButton;
    [SerializeField] private SettingsCanvas _settingsCanvas;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private string scoreBaseText = "SCORE: ";
    [SerializeField] private LogoCanvas logoCanvas;

    private int count = 0;

    private void Awake()
    {
        settingsButton.onClick.AddListener(() =>
        {
            PlaySoundButton();
            this.HideCanvas();
            _settingsCanvas.ShowCanvas(this);
        });
        
        backButton.onClick.AddListener((() =>
        {
            HideCanvas();
            logoCanvas.ShowCanvas();
        }));
        
    }
    public override void ShowCanvas(int _count)
    {
        count = _count;
        scoreText.text = scoreBaseText + count;
        base.ShowCanvas();
    }
}
