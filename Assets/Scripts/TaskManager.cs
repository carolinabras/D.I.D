using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskManager : MonoBehaviour
{
    
    [SerializeField] 
    private TMPro.TMP_Text taskText;

    public Task currentTask;

    public AudioSource audioSource;
    public void playSoundEffect() {
        audioSource.Play();
    }
     public void Start()
    {


        if ( taskText == null ) {
            Debug.Log("Task text not found");
            return;
        }

        GameObject LevelGameObject = GameObject.Find("LevelProperties");
        if (LevelGameObject == null) {
            Debug.Log("LevelProperties not found");
            return;
        }

        LevelProperties levelProperties = LevelGameObject.GetComponent<LevelProperties>();
        if (levelProperties == null) {
            Debug.Log("LevelProperties Component not found");
            return;
        }
        
        currentTask = levelProperties.getCurrentTask();
        if (currentTask == null) {
            Debug.Log("Task not found");
            return;
        }

        taskText.text = currentTask.description;
        Debug.Log("Task text set to: " + currentTask.description);

        Debug.Log("Task proficiency: " + currentTask.proficiency);

    }

    public void SelectDogButton(){
        playSoundEffect();

        if (currentTask.proficiency == "animal"){
            Debug.Log("dog");
            ScoreManager.Instance.AddPoints(20);
            currentTask.isCompleted = true;
            UnityEngine.SceneManagement.SceneManager.LoadScene("Phase3");
        }
        else{
            ScoreManager.Instance.AddPoints(-20);
            UnityEngine.SceneManagement.SceneManager.LoadScene("Phase3");
        }

    }

    public void SelectChildButton(){
        playSoundEffect();
        if (currentTask.proficiency == "criative"){
            ScoreManager.Instance.AddPoints(20);
            currentTask.isCompleted = true;
            UnityEngine.SceneManagement.SceneManager.LoadScene("Phase3");
        }
        else{
            ScoreManager.Instance.AddPoints(-20);
            UnityEngine.SceneManagement.SceneManager.LoadScene("Phase3");
            
        }

    }

    public void SelectElderButton(){
        playSoundEffect();
        if (currentTask.proficiency == "calm"){
            ScoreManager.Instance.AddPoints(20);
            currentTask.isCompleted = true;
            UnityEngine.SceneManagement.SceneManager.LoadScene("Phase3");
        }
        else{
            ScoreManager.Instance.AddPoints(-20);
            UnityEngine.SceneManagement.SceneManager.LoadScene("Phase3");
            
        }

    }

    public void SelectMaskButton(){
        playSoundEffect();
        if (currentTask.proficiency == "energy"){
            ScoreManager.Instance.AddPoints(20);
            currentTask.isCompleted = true;
            UnityEngine.SceneManagement.SceneManager.LoadScene("Phase3");
        }
        else{
            ScoreManager.Instance.AddPoints(-20);
            UnityEngine.SceneManagement.SceneManager.LoadScene("Phase3");
            
        }
    }

}
