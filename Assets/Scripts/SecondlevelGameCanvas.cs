using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SecondlevelGameCanvas : Page 
{
    [SerializeField] private Button settingsButton;
    [SerializeField] private SettingsCanvas _settingsCanvas;
    [SerializeField] private ThirdlevelGameCanvas thirdlevelGameCanvas;
    [SerializeField] private Button mainButton;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private string scoreBaseText = "SCORE: ";
    [SerializeField] private string scoreFunText = "OHHHH YEAH LET'S GO";
     
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
            if (count == 60)
            {
                scoreText.text = scoreFunText;
            }
            if (count == 80)
            {
                HideCanvas();
                thirdlevelGameCanvas.ShowCanvas();
            }
        });
    }

    public override void ShowCanvas(int _count)
    {
        count = _count;
        scoreText.text = scoreBaseText + count;
        base.ShowCanvas();
    }
}
