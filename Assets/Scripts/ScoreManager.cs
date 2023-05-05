using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    public int score = 0;

    [SerializeField] 
    private TMPro.TMP_Text scoreText;


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void AddPoints(int points)
    {
        score += points;
        
        // Debug.Log("Score: " + score); adicionar UI para mostrar o score
        //add points é chamado quando profiency task == proficiency alter
    }
}

