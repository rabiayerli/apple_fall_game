using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //Instantiate
    //Random.Range
    //Coroutine

    public GameObject applePrefab;

    public void Start()
    {
        StartCoroutine("AppleDown");
    }

    public IEnumerator AppleDown()
    {
        while (true)
        {
            var position = new Vector2(Random.Range(-9f, 9f), Random.Range(14f, 25f));
            Instantiate(applePrefab, position, Quaternion.identity);
            yield return new WaitForSecondsRealtime(1);
        }
    }
}