using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchMinigame : MonoBehaviour
{
    static public SwitchMinigame Instance;

    public int switchCount;
    private int onCount = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        SceneManager.LoadScene(nextSceneIndex);

    }

    public void SwitchChange(int points)
    {
        onCount = onCount + points;
        if (onCount == switchCount)
        {
            LoadNextScene();
            gameObject.SetActive(false);
        }
    }
}
