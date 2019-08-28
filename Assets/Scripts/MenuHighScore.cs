using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuHighScore : MonoBehaviour
{
    // Start is called before the first frame update
    public Text HighScore;
    void Start()
    {
        HighScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
}
