using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI score;
    int totalapplescore; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ilk degdigi anda calisir.

        if (collision.gameObject.CompareTag("Apple") && gameObject.CompareTag("Player"))
        {
            totalapplescore += 5;
            Debug.Log(totalapplescore);
            collision.gameObject.SetActive(false);
            score.text = "Score : " + totalapplescore.ToString();
        }
    }

    public void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        gameObject.transform.position = mousePos;
        Cursor.visible = false;
    }
}
