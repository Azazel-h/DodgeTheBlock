using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Animator animator;
    public Image image;
    public ChangeColor changer;
    public float slowness = 10f;
    // Start is called before the first frame update

    public void DisableImage()
    {
        image.enabled = false;
    }

    public void AnimationFadeOut()
    {
        image.enabled = true;
        animator.SetTrigger("FadeOut");
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
        image.enabled = false;
    }

    public void EndGame()
    {
        FindObjectOfType<ScoreText>().Game = false;
        PlayGamesScript.AddScoreToLeaderboard(GPGSIds.leaderboard_best_players, FindObjectOfType<ScoreText>().score);
        AdScript.instance.ShowFullscreenAd();
        changer.ChangeBoxToBlack();
        StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel()
    {
        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        yield return new WaitForSeconds(1f / slowness);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
