using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject background;
    public GameObject background1;
    public GameObject box;
    public GameObject player;
    public Text scoretext;
    public Button pauseButton;
    public Text L;
    public Text R;
    public Camera mainCamera;

    SpriteRenderer sr1;
    SpriteRenderer sr2;
    SpriteRenderer sr_player;
    SpriteRenderer box_sr;
    TrailRenderer tr_player;

    public Color red1;
    public Color red2;
    public Color DarkGrey;
    public Color DarkDarkGrey;
    public Color ButtonColor;
    public Color zm;

    void Start()
    {
        sr1 = background.GetComponent<SpriteRenderer>();
        sr2 = background1.GetComponent<SpriteRenderer>();
        sr_player = player.GetComponent<SpriteRenderer>();
        tr_player = player.GetComponent<TrailRenderer>();
        box_sr = box.GetComponent<SpriteRenderer>();
        zm.a = 0.7f;
    }

    public void ChangeBoxToBlack()
    {
        box_sr.color = Color.black;
    }

    public void ChangeToWhite()
    {
        sr1.color = Color.Lerp(sr1.color, Color.white, Time.fixedDeltaTime * 3f);
        sr2.color = Color.Lerp(sr2.color, Color.gray, Time.fixedDeltaTime * 3f);
        sr_player.color = Color.Lerp(sr_player.color, Color.black, Time.fixedDeltaTime * 3f);
        mainCamera.backgroundColor = Color.Lerp(sr2.color, Color.gray, Time.fixedDeltaTime * 3f);
        scoretext.color = Color.Lerp(scoretext.color, Color.white, Time.fixedDeltaTime * 3f);
        pauseButton.image.color = Color.Lerp(pauseButton.image.color, Color.white, Time.fixedDeltaTime * 3f);
        tr_player.startColor = Color.Lerp(tr_player.startColor, Color.black, Time.fixedDeltaTime * 3f);
        box_sr.color = Color.Lerp(box_sr.color, Color.black, Time.fixedDeltaTime * 5f);
    }

    public void ChangeToRed()
    {
        sr1.color = Color.Lerp(sr1.color, red1, Time.fixedDeltaTime * 3f);
        sr2.color = Color.Lerp(sr2.color, red2, Time.fixedDeltaTime * 3f);
        sr_player.color = Color.Lerp(sr_player.color, Color.white, Time.fixedDeltaTime * 3f);
        mainCamera.backgroundColor = Color.Lerp(sr2.color, red2, Time.fixedDeltaTime * 3f);
        scoretext.color = Color.Lerp(scoretext.color, Color.black, Time.fixedDeltaTime * 3f);
        pauseButton.image.color = Color.Lerp(pauseButton.image.color, ButtonColor, Time.fixedDeltaTime * 3f);
        tr_player.startColor = Color.Lerp(tr_player.startColor, Color.white, Time.fixedDeltaTime * 3f);
        box_sr.color = Color.Lerp(box_sr.color, Color.black, Time.fixedDeltaTime * 5f);
    }

    public void ChangeToBlack()
    {
        sr1.color = Color.Lerp(sr1.color, DarkDarkGrey, Time.fixedDeltaTime * 3f);
        sr2.color = Color.Lerp(sr2.color, DarkGrey, Time.fixedDeltaTime * 3f);
        sr_player.color = Color.Lerp(sr_player.color, Color.white, Time.fixedDeltaTime * 3f);
        mainCamera.backgroundColor = Color.Lerp(sr2.color, DarkGrey, Time.fixedDeltaTime * 3f);
        scoretext.color = Color.Lerp(scoretext.color, Color.white, Time.fixedDeltaTime * 3f);
        pauseButton.image.color = Color.Lerp(pauseButton.image.color, Color.white, Time.fixedDeltaTime * 3f);
        tr_player.startColor = Color.Lerp(tr_player.startColor, Color.white, Time.fixedDeltaTime * 3f);
        box_sr.color = Color.Lerp(box_sr.color, Color.white, Time.fixedDeltaTime * 5f);
    }
}
