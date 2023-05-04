using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EventScript : MonoBehaviour
{
    private int num;
    private Coroutine minigameCoroutine;

    public static event Action Minigame;
    // Start is called before the first frame update
    void Start()
    {
        minigameCoroutine = StartCoroutine(ActivateMinigame());
    }

    IEnumerator ActivateMinigame()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            num = UnityEngine.Random.Range(0, 101);
            if (num <= 10)
            {
                Minigame?.Invoke();
                Debug.Log(num);
                StopCoroutine(minigameCoroutine);
                //GuardarTempo
                //Passar para proxima scene
            }
        }
    }
}
