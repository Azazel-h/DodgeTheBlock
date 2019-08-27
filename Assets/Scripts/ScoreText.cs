using UnityEngine.UI;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public Text scoreText;
    public Text HighScore;
    public ChangeColor changer;
    public int score = 0;
    public bool Game = true;
    public bool FirstSpawned = false;
    public bool  lol = false;
    private int randomIndex = 2;
    private int state = 2;

    void Start() {
        HighScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    void Update()
    {
        if (Game && FirstSpawned)
        {
            scoreText.text = "Score: " + score.ToString();
            LolScore();
            if (lol)
            {
                
                switch (randomIndex)
                {
                    case 0:
                        changer.ChangeToBlack();
                        state = 0;
                        break;

                    case 1:
                        changer.ChangeToWhite();
                        state = 1;
                        break;

                    case 2:
                        changer.ChangeToRed();
                        state = 2;
                        break;
                        
                }
            }
            
        }
       
    }

    public void ScoreUpdate()
    {
        score++;
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            HighScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        }
        lol = false;
        randomIndex = Random.Range(0, 3);
        while (randomIndex == state)
        {
            randomIndex = Random.Range(0, 3);
        }

    }

    public void LolScore()
    {
        if (score % 15 == 0 && score > 0)
        {
            lol = true;
        }
    }

}
