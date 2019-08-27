using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator animator;
    public GameObject pauseMenuUI;
    public static bool paused = false;
    // Update is called once per frame


     
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
    }

    public void ResumeAnimationRender()
    {
        AdScript.instance.HideBanner();
        animator.Play("ResumeAnimation");
    }

    public void PauseAnimationRender()
    {
        AdScript.instance.RequestBanner();
        animator.Play("PauseFadeIn");
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
        
    }
}
