using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject[] gamesArray;
    private int num;
    // Start is called before the first frame update
    void Start()
    {
        EventScript.Minigame += ActivateMinigame;
        num = Random.Range(0, gamesArray.Length);
    }

    private void ActivateMinigame()
    {
        gamesArray[num].SetActive(true);
    }

    private void OnDisable()
    {
        EventScript.Minigame -= ActivateMinigame;
    }
}
