using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    private Animator animator;
    private CanvasGroup canvas;
    void Start()
    {
        animator = GetComponent<Animator>();
        canvas = GetComponent<CanvasGroup>();

        canvas.interactable = false;
        canvas.blocksRaycasts = false;
    }
    public void Show()
    {
        animator.Play("FadeIn");
        canvas.interactable = true;
        canvas.blocksRaycasts = true;
    }

    public void Hide()
    {
        animator.Play("FadeOut");
        canvas.interactable = false;
        canvas.blocksRaycasts = false;
    }

}
