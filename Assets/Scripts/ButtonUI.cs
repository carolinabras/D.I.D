using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonUI : MonoBehaviour
{
    [SerializeField] const string phase2 = "Phase2";
    GameObject blackScreen;
    const int fadeSpeed = 1;

    void Start() {
        blackScreen = GameObject.Find("BlackScreenHolder").GetComponent<BlackScreen>().blackScreen;
    }
    
    public void TaskButton() {
        ButtonProperties buttonProperties = gameObject.GetComponent<ButtonProperties>();
        LevelProperties levelProperties = GameObject.Find("LevelProperties").GetComponent<LevelProperties>();
        levelProperties.setCurrentTask(buttonProperties.getTask());
        StartCoroutine(FadeToBlack());
    }

    public IEnumerator FadeToBlack() {
        blackScreen.SetActive(true);
        blackScreen.transform.SetAsLastSibling ();
        Color color = blackScreen.GetComponent<Image>().color;
        float fadeAmount = color.a;
        //Debug.Log(fadeAmount);

        while (fadeAmount < 1) {
            Debug.Log(fadeAmount);
            fadeAmount += fadeSpeed * Time.deltaTime;

            Color newColor = new Color(color.r, color.g, color.b, fadeAmount);
            blackScreen.GetComponent<Image>().color = newColor;
            yield return null;
        }

        SceneManager.LoadScene(phase2);
    }

}
