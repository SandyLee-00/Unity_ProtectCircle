using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public static gameManager I;

    public GameObject square;
    public GameObject endPanel;

    public Text timeTxt;
    float time = 0.0f;

    public Text txt_myScore;
    public Text txt_bestScore;

    bool isRunning = true;

    private void Awake()
    {
        I = this;
    }

    void Start()
    {
        Time.timeScale = 1.0f;
        InvokeRepeating("makeSquare", 0.0f, 0.5f);
    }

    void Update()
    {
        if (isRunning)
        {
            time += Time.deltaTime;
            timeTxt.text = time.ToString("N1");
        }        
    }

    void makeSquare()
    {
        Instantiate(square);
    }

    public void gameOver()
    {
        isRunning = false;
        Time.timeScale = 0.0f;
        txt_myScore.text = time.ToString("N1");

        if(PlayerPrefs.HasKey("bestScore") == false)
        {
            PlayerPrefs.SetFloat("bestScore", time);
        }
        else if(PlayerPrefs.GetFloat("bestScore") < time)
        {
            PlayerPrefs.SetFloat("bestScore", time);
        }
        txt_bestScore.text = PlayerPrefs.GetFloat("bestScore").ToString("N1");

        endPanel.SetActive(true);
    }

    public void restart()
    {
        SceneManager.LoadScene("MainScene");
    }

}
