using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public static gameManager I;

    public GameObject square;
    public GameObject endPanel;

    public Text timeTxt;
    float time = 0.0f;

    private void Awake()
    {
        I = this;
    }

    void Start()
    {
        InvokeRepeating("makeSquare", 0.0f, 0.5f);
    }

    void Update()
    {
        time += Time.deltaTime;
        timeTxt.text = time.ToString("N1");
    }

    void makeSquare()
    {
        Instantiate(square);
    }

    public void gameOver()
    {
        Time.timeScale = 0.0f;
        endPanel.SetActive(true);
    }
}
