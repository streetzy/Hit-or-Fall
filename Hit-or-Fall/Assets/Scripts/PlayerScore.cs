using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScore : MonoBehaviour
{

    public static float scoreNumber;
    public GameTime gameTime;
    private TMP_Text score;

    void OnEnable()
    {
        score = GameObject.FindGameObjectWithTag("Score Number").GetComponent<TMP_Text>();
        score.text = "0";
        scoreNumber = 0;
    }

    void Update()
    {
        score.text = (Mathf.Round(gameTime.time * 10) + scoreNumber).ToString();
        if (MenuSelection.scoreList.Count > 3) { MenuSelection.scoreList.RemoveAt(3); }
    }

    void OnDisable()
    {
        if (Time.timeScale == 1) { MenuSelection.scoreList.Insert(0, float.Parse(score.text)); }
    }

}
