using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour {

    public static LevelManager instance;

    public GameObject Ball;

    public int playerScore;
    public int AIScore;

    public TextMeshProUGUI playerScoreText;

    public TextMeshProUGUI AIScoreText;

    private void Awake()
    {
        instance = this;
    }

    public void Scored(Scorer scorer){
      switch (scorer)
        {
            case Scorer.Player:
                playerScore++;
                break;
            case Scorer.AI:
                AIScore++;
                break;
        }

        Ball.GetComponent<Ball>().Reset();
    }

    private void OnGUI(){
        AIScoreText.text = AIScore.ToString();
        playerScoreText.text = playerScore.ToString();
    }
}

public enum Scorer
{
    AI,

    Player
}