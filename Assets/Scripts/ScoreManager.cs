using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    public int score = 0;


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        GameObject scoreTextGameObject = GameObject.Find("ScoreText");
        if(scoreTextGameObject != null)
        {
            TMPro.TMP_Text scoreText = scoreTextGameObject.GetComponent<TMPro.TMP_Text>();
            scoreText.text = "0";
        }

        
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // called second
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        GameObject scoreTextGameObject = GameObject.Find("ScoreText");
        if(scoreTextGameObject != null)
        {
            TMPro.TMP_Text scoreText = scoreTextGameObject.GetComponent<TMPro.TMP_Text>();
            scoreText.text = score.ToString();
        }      
    }

    private void OnDestroy ()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    public void AddPoints(int points)
    {
        score += points;

        GameObject scoreTextGameObject = GameObject.Find("ScoreText");
        if(scoreTextGameObject != null)
        {
            TMPro.TMP_Text scoreText = scoreTextGameObject.GetComponent<TMPro.TMP_Text>();
            scoreText.text = score.ToString();
        }
        // Debug.Log("Score: " + score); adicionar UI para mostrar o score
        //add points é chamado quando profiency task == proficiency alter
    }
}

