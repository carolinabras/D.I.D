using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskManager : MonoBehaviour
{
    
    [SerializeField] 
    private TMPro.TMP_Text taskText;

    public Sprite shadowSprite;

  


    public Task currentTask;

    public bool shadowActive = false;

    public AudioSource audioSource;


public GameObject dogButton;
public GameObject dogShadowButton;

public GameObject childButton;

public GameObject childShadowButton;

public GameObject elderButton;

public GameObject elderShadowButton;

public GameObject maskButton;

public GameObject maskShadowButton;



    public void playSoundEffect() {
        audioSource.Play();
    }
     public void Start()
    {

        int randomNumber = Random.Range(0, 7);
        if (randomNumber > 5) {
            shadowActive = true;
        }
        else {
            shadowActive = false;
        }

        //if shadow active then pick two random buttons from the four: "Dog", "Child", "Elder", "Mask" and make them inactive and change their sprite to the shadow sprite
        if (shadowActive) {
            

            GameObject dogButton = this.dogButton;
            GameObject childButton = GameObject.Find("Child");
            GameObject elderButton = GameObject.Find("Elder");
            GameObject maskButton = GameObject.Find("Mask");

            GameObject[] buttons = {dogButton, childButton, elderButton, maskButton};
            int randomButton1 = Random.Range(0, 4);
            int randomButton2 = Random.Range(0, 4);

            while (randomButton1 == randomButton2) {
                randomButton2 = Random.Range(0, 4);
            }

            if (buttons[randomButton1] == dogButton) {
                dogButton.SetActive(false);
                dogShadowButton.SetActive(true);
            }
            else {
                buttons[randomButton1].SetActive(false);
            }

             if (buttons[randomButton1] == childButton) {
                childButton.SetActive(false);
                childShadowButton.SetActive(true);
            }
            else {
                buttons[randomButton1].SetActive(false);
            }

             if (buttons[randomButton1] == elderButton) {
                elderButton.SetActive(false);
                elderShadowButton.SetActive(true);
            }
            else {
                buttons[randomButton1].SetActive(false);
            }

            if (buttons[randomButton1] == maskButton) {
                maskButton.SetActive(false);
                maskShadowButton.SetActive(true);
            }
            else {
                buttons[randomButton1].SetActive(false);
            }

            if (buttons[randomButton2] == dogButton) {
                dogButton.SetActive(false);
                dogShadowButton.SetActive(true);
            }
            else {
                buttons[randomButton2].SetActive(false);
            }

             if (buttons[randomButton2] == childButton) {
                childButton.SetActive(false);
                childShadowButton.SetActive(true);
            }
            else {
                buttons[randomButton2].SetActive(false);
            }

             if (buttons[randomButton2] == elderButton) {
                elderButton.SetActive(false);
                elderShadowButton.SetActive(true);
            }
            else {
                buttons[randomButton2].SetActive(false);
            }

            if (buttons[randomButton2] == maskButton) {
                maskButton.SetActive(false);
                maskShadowButton.SetActive(true);
            }
            else {
                buttons[randomButton2].SetActive(false);
            }

            // Button button1 = buttons[randomButton1].GetComponent<Button>();
            // if (button1 == null) {
            //     Debug.Log("Button not found");
            //     return;
            // }
            // Button button2 = buttons[randomButton2].GetComponent<Button>();
            // if (button2 == null) {
            //     Debug.Log("Button not found");
            //     return;
            // }

            // button1.interactable = false;
            // button2.interactable = false;
            // button1.image.sprite = shadowSprite;
            // button2.image.sprite = shadowSprite;
        }

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

