using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject startUI;
    public GameObject gameUI;
    public Text scoreText;
    int score;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameStart()
    {
        startUI.SetActive(false);
        gameUI.SetActive(true);
    }

    public void ScoreUp()
    {
        score++;
        scoreText.text = " " + score;
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
