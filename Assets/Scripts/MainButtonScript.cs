using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainButtonScript : MonoBehaviour
{
    private Button mainButton;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private string scoreBaseText = "SCORE: ";
    [SerializeField] private string scoreFunText;
    [SerializeField] private GameObject nextLevel;

    private int count = 0;

    private void Awake()
    {
        mainButton = GetComponent<Button>();
        
        mainButton.onClick.AddListener(() =>
        {
            count++;
            scoreText.text = scoreBaseText + count;
            if (count == 10)
            {
                scoreText.text = scoreFunText;
            }

            if (count > 100)
            {
                count = 0;
                transform.parent.gameObject.SetActive(false);
                nextLevel.SetActive(true);
            }
        });
    }
}
