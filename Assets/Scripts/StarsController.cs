using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsController : MonoBehaviour
{
    [SerializeField] private StarAnimationCanvas animationCanvas;

    public void AnimationEnds()
    {
        animationCanvas.AnimationEnd();
    }
}