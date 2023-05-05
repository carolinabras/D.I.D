using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class EventScript : MonoBehaviour
{
    private int num, numRolls = 0;
    private Coroutine minigameCoroutine;
    public float timeLeft;
    public int minigameChance = 40;

    public static event Action Minigame;
    // Start is called before the first frame update
    void Start()
    {
        minigameCoroutine = StartCoroutine(ActivateMinigame());
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        SceneManager.LoadScene(nextSceneIndex);

    }

    IEnumerator ActivateMinigame()
    {
        while (numRolls < 7)
        {
            yield return new WaitForSeconds(1f);
            num = UnityEngine.Random.Range(0, 101);
            numRolls += 1;
            if (num <= minigameChance)
            {
                Minigame?.Invoke();
                StopCoroutine(minigameCoroutine);
            }
        }
        LoadNextScene();
    }
}
