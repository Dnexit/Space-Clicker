using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainButtonScript : MonoBehaviour
{
    private Button mainButton;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private string scoreFunText;
    [SerializeField] private LevelManager _levelManager;

    private int count = 0;

    private void OnValidate()
    {
        _levelManager = FindObjectOfType<LevelManager>();
    }

    private void Awake()
    {
        mainButton = GetComponent<Button>();
        
        mainButton.onClick.AddListener(() =>
        {
            
            if (Input.GetKey(KeyCode.LeftShift))
                count += 100;
            else
                count++;

            scoreText.text = $"SCORE: {count:D5}";
            
            
            if (count == 10)
            {
                scoreText.text = scoreFunText;
            }

            if (count >= _levelManager.CurrentLevel.CountToNext)
            {
                _levelManager.NextLevel();
            }
        });
    }
}
