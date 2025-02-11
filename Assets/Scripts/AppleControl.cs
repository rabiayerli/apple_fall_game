using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleControl : MonoBehaviour
{
    /*
    public void Start()
    {
        Destroy(gameObject, 5f);
    }
    */
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.CompareTag("Apple") && collision.gameObject.CompareTag("Finish"))
        {
            gameObject.SetActive(false);
            //Destroy(gameObject, 2f);
        }
    }
}
