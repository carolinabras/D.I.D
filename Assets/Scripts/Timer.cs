using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float currentTime;
    public float startingTime = 10f;

    [SerializeField] TextMeshProUGUI countdownText;
    public Task currentTask;
    void Start()
    {
        currentTime = startingTime;
        GameObject LevelGameObject = GameObject.Find("LevelProperties");
        LevelProperties levelProperties = LevelGameObject.GetComponent<LevelProperties>();
        currentTask = levelProperties.getCurrentTask();
    }

    
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("F1");

        if (currentTime <= 0)
        {
            currentTime = 0;
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
            if (!currentTask.isCompleted)
            {
                ScoreManager.Instance.AddPoints(-5);
            }
            SceneManager.LoadScene("Phase5_fail");
            gameObject.SetActive(false);
        }
    }
}
