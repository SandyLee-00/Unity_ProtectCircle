using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject square;

    void Start()
    {
        InvokeRepeating("makeSquare", 0.0f, 0.5f);
    }

    void Update()
    {
        
    }

    void makeSquare()
    {
        Instantiate(square);
    }
}
