using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragDropGame : MonoBehaviour
{
    static public DragDropGame Instance;

    public int dropCount;
    private int onCount = 0;

    public Task currentTask;

    private void Awake()
    {
        Instance = this;
        GameObject LevelGameObject = GameObject.Find("LevelProperties");
        LevelProperties levelProperties = LevelGameObject.GetComponent<LevelProperties>();
        currentTask = levelProperties.getCurrentTask();
    }


    public void DropChange(int points)
    {
        onCount = onCount + points;
        if (onCount == dropCount)
        {
            if (currentTask.isCompleted)
            {
                SceneManager.LoadScene("Phase4_sucess");
            }
            else
            {
                SceneManager.LoadScene("Phase5_fail");
            }
            gameObject.SetActive(false);
        }
    }
}
