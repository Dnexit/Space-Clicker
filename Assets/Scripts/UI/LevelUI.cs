using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _levelNumberText;
    [SerializeField] private Image _mainButtonImage;
    [SerializeField] private Image _prevMainButtonImage;
    [SerializeField] private GameObject _winScreen;
    [SerializeField] private LevelManager _levelManager;
    
    private void OnValidate()
    {
        _levelManager = FindObjectOfType<LevelManager>();
    }

    private void Awake()
    {
        //подписываемся на события менеджера уровней
        _levelManager.LevelChanged.AddListener(ChangeUI);
        _levelManager.Won.AddListener(() =>
        {
            _winScreen.SetActive(true);
            gameObject.SetActive(false);
        });
    }

    public void ChangeUI(int levelNumber, Sprite currentMainSprite)
    {
        _prevMainButtonImage.sprite = _mainButtonImage.sprite; //Присваем картинку с предыдущего уровня
        _mainButtonImage.sprite = currentMainSprite; //Присваиваем новую картинку для кноки кликера
        
        //TODO: Исправить это говно
        //Убираем прозрачность если есть картинка
        if (_prevMainButtonImage.sprite)
        {
            _prevMainButtonImage.color = new Color(1,1,1,1);
        }
        
        _levelNumberText.text = $"{++levelNumber} LEVEL";
    }
}
