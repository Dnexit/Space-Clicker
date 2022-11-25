using System;
using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace
{
    public class LevelManager : MonoBehaviour
    {
        [SerializeField] private Level[] _levels; //Данные о уровнях

        private int _currentLevelNumber = 0;

        public Level CurrentLevel => _levels[_currentLevelNumber];
        
        public UnityEvent<int, Sprite> LevelChanged; //Событие смены уровня, передаёт индекс уровня и картинку планеты
        public UnityEvent Won; // Событие победы

        public void StartGame()
        {
            LevelChanged?.Invoke(_currentLevelNumber, _levels[_currentLevelNumber].Image);
        }

        public void NextLevel()
        {
            _currentLevelNumber++;
            if(_currentLevelNumber >= _levels.Length)
                Won?.Invoke();
            else
                LevelChanged?.Invoke(_currentLevelNumber, _levels[_currentLevelNumber].Image);
        }
    }

    [Serializable]
    public struct Level
    {
        public Sprite Image;
        public int CountToNext;
    }
}