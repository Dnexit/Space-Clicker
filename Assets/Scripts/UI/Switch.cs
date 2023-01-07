using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Switch : MonoBehaviour
{ 
    public bool IsActive
    {
        get => isActiv;
        set
        {
            if (value)
            {
                OnEnable?.Invoke();
            }
            else
            {
                OnDisable?.Invoke();
            }
            StopAllCoroutines();
            StartCoroutine(KnobSlide(knob, value? rightKnobPos:leftKnobPos, slideTime));
            StartCoroutine(BackgroundSlide(mask, value? rightBackgroundPos:leftBackgroundPos, value? rightBackgroundSize:leftBackgroundSize, slideTime));
            isActiv = value;
        }
    }

    [SerializeField]private bool isActiv;
    [SerializeField] private float slideTime = 1f;
    
    [SerializeField]private RectTransform knob;
    [SerializeField]private RectTransform mask;
    
    private Vector2 leftKnobPos; 
    private Vector2 rightKnobPos;

    private Button button;
    
    private Vector2 leftBackgroundPos;
    private Vector2 rightBackgroundPos;
    private Vector2 leftBackgroundSize;
    private Vector2 rightBackgroundSize;

    [Space(30f)]
    public UnityEvent OnEnable;
    public UnityEvent OnDisable;

    private void Awake()
    {
        button = GetComponent<Button>();
        
        leftKnobPos = new Vector2(-knob.sizeDelta.x / 2, 0);
        rightKnobPos = new Vector2(knob.sizeDelta.x / 2, 0);
        
        leftBackgroundPos = new Vector2(-knob.sizeDelta.x, 0);
        rightBackgroundPos = new Vector2(0, 0);
        
        leftBackgroundSize = new Vector2(0, knob.sizeDelta.y);
        rightBackgroundSize = new Vector2(GetComponent<RectTransform>().sizeDelta.x, knob.sizeDelta.y);
        
        button.onClick.AddListener((() => IsActive = !IsActive));
        IsActive = IsActive;
    }

    private IEnumerator KnobSlide(RectTransform _transform, Vector2 _finalPosition, float _slideTime)
    {
        while (_transform.anchoredPosition != _finalPosition)
        {
            _transform.anchoredPosition = Vector2.Lerp(_transform.anchoredPosition, _finalPosition, _slideTime);
            yield return new WaitForEndOfFrame();
        }
    }
    
    private IEnumerator BackgroundSlide(RectTransform _transform, Vector2 _finalPosition, Vector2 _finalSize, float _slideTime)
    {
        while (_transform.anchoredPosition != _finalPosition)
        {
            _transform.anchoredPosition = Vector2.Lerp(_transform.anchoredPosition, _finalPosition, _slideTime);
            _transform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Vector2.Lerp(_transform.sizeDelta, _finalSize, _slideTime).x);
            yield return new WaitForEndOfFrame();
        }
    }
}