using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinishGame : MonoBehaviour
{
    int life = 5;
    public TextMeshProUGUI lifetext;
    public GameObject finishscreen;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Apple"))
        {
            if (life > 0)
            {
                life--;
                lifetext.text = life.ToString();
                if (life == 0)
                {
                    finishscreen.SetActive(true);
                    Time.timeScale = 0;
                }
            }
        }
    }
}
