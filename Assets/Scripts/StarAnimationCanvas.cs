using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarAnimationCanvas : Page
{
    private Page nextPage;
    private int _count;
    
    
    public void ShowCanvas(Page page, int count)
    {
        nextPage = page;
        _count = count;
        base.ShowCanvas();
    }

    public void AnimationEnd()
    {
        HideCanvas();
        nextPage.ShowCanvas(_count);
    }
}
