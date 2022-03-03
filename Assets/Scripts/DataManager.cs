using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public static string playerName;
    public static string bestPlayerName;
    public static int bestScore;

    public Text nameInputText;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        if (playerName == null)
        {
            playerName = "Player";
        }

        if (bestPlayerName == null)
        {
            bestPlayerName = "John";
        }

        if (bestScore == 0)
        {
            bestScore = 10;
        }
    }

    public void StartGame()
    {
        playerName = nameInputText.text;
        SceneManager.LoadScene(1);
        //Debug.Log(playerName);
    }
}
