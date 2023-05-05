using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragDropGame : MonoBehaviour
{
    static public DragDropGame Instance;

    public int dropCount;
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

    public void DropChange(int points)
    {
        onCount = onCount + points;
        if (onCount == dropCount)
        {
            LoadNextScene();
            gameObject.SetActive(false);
        }
    }
}
