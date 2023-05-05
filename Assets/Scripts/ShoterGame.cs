using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShoterGame : MonoBehaviour
{
    static public ShoterGame Instance;

    public int targetCount;
    private int deadCount = 0;

    public Texture2D cursorTexture;
    public Task currentTask;

    private void Awake()
    {
        Instance = this;
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
        GameObject LevelGameObject = GameObject.Find("LevelProperties");
        LevelProperties levelProperties = LevelGameObject.GetComponent<LevelProperties>();
        currentTask = levelProperties.getCurrentTask();
    }



    public void KillChange(int points)
    {
        deadCount = deadCount + points;
        if (deadCount == targetCount)
        {
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
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
