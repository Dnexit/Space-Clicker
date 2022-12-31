using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SecondlevelGameCanvas : Page 
{
    [SerializeField] private Button settingsButton;
    [SerializeField] private SettingsCanvas _settingsCanvas;
    [SerializeField] private Button mainButton;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private string scoreBaseText = "SCORE: ";
    [SerializeField] private string scoreFunText;
     
    private int count = 0;

    private void Awake()
    {
        settingsButton.onClick.AddListener(() =>
        {
            this.HideCanvas();
            _settingsCanvas.ShowCanvas(this);
        });

        mainButton.onClick.AddListener(() =>
        {
            count++;
            scoreText.text = scoreBaseText + count;
            if (count == 10)
            {
                scoreText.text = scoreFunText;
            }
        });
    }

    public void ShowCanvas(int _count)
    {
        count = _count;
        base.ShowCanvas();
    }
}
