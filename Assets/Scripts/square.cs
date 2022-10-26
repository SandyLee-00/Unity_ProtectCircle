using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square : MonoBehaviour
{
    void Start()
    {
        float x = Random.Range(-3.0f, 3.0f);
        float y = Random.Range(5.0f, 6.0f);

        transform.position = new Vector3(x, y, 0);

        float size = Random.Range(0.5f, 1.5f);
        transform.localScale = new Vector3(size, size, 1);
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ballon")
        {
            gameManager.I.gameOver();
            Debug.Log("@square col ballon");
        }
    }
}
