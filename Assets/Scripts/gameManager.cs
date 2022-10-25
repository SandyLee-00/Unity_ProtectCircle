using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject square;

    public Text timeTxt;
    float time = 0.0f;

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
}
