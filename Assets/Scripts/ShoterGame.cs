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

    private void Awake()
    {
        Instance = this;
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        SceneManager.LoadScene(nextSceneIndex);

    }

    public void KillChange(int points)
    {
        deadCount = deadCount + points;
        if (deadCount == targetCount)
        {
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
            LoadNextScene();
            gameObject.SetActive(false);
        }
    }
}
