using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScoreText : MonoBehaviour
{
    public Text bestScoreText;

    private void Awake()
    {
        bestScoreText.text = "Best score: " + DataManager.bestPlayerName + ": " + DataManager.bestScore;
    }
}
