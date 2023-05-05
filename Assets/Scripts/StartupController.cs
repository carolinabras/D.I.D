using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartupController : MonoBehaviour
{
    [SerializeField] const string phase1 = "Phase1";
    public GameObject blackScreen;
    public GameObject startButton;
    public GameObject imageOn;
    public GameObject bootingUp;
    const float fadeSpeed = 0.5f;
    const int upFadeSpeed = 1;

    void Start() {
        StartCoroutine(FadeFromBlack());
    }

    public IEnumerator FadeFromBlack() {
        yield return new WaitForSeconds(1);
        Color color = blackScreen.GetComponent<Image>().color;
        float fadeAmount = color.a;
        //Debug.Log(fadeAmount);

        while (fadeAmount > 0) {
            Debug.Log(fadeAmount);
            fadeAmount -= fadeSpeed * Time.deltaTime;

            Color newColor = new Color(color.r, color.g, color.b, fadeAmount);
            blackScreen.GetComponent<Image>().color = newColor;
            yield return null;
        }

        blackScreen.SetActive(false);
        ShowStartButton();
        //SceneManager.LoadScene(phase2);
    }

    public void ShowStartButton() {
        startButton.SetActive(true);
        // mostrar o botao
    }

    public void StartButton() {
        startButton.SetActive(false);
        StartCoroutine(AnimateStart());
        /*
        Animation anim = bootingUp.GetComponent<Animation>();
        // wait for animation to finish
        imageOn.SetActive(true);
        // wait for a sec
        
        // load phase1 with fade to black?
        SceneManager.LoadScene(phase1);
        */
    }

    public IEnumerator AnimateStart() {
        //Animation anim = bootingUp.GetComponent<Animation>();
        bootingUp.SetActive(true);

        yield return new WaitForSeconds(0.5f);
        // wait for animation to finish
        imageOn.SetActive(true);
        // wait for a sec

        yield return new WaitForSeconds(1.5f);
        // load phase1 with fade to black?

        blackScreen.SetActive(true);
        blackScreen.transform.SetAsLastSibling ();
        Color color = blackScreen.GetComponent<Image>().color;
        float fadeAmount = color.a;

        while (fadeAmount < 1) {
            fadeAmount += upFadeSpeed * Time.deltaTime;

            Color newColor = new Color(color.r, color.g, color.b, fadeAmount);
            blackScreen.GetComponent<Image>().color = newColor;
            yield return null;
        }

        SceneManager.LoadScene(phase1);
    }

    /*
    blackScreen.SetActive(true);
        blackScreen.transform.SetAsLastSibling ();
        Color color = blackScreen.GetComponent<Image>().color;
        float fadeAmount = color.a;

        while (fadeAmount < 1) {
            fadeAmount += fadeSpeed * Time.deltaTime;

            Color newColor = new Color(color.r, color.g, color.b, fadeAmount);
            blackScreen.GetComponent<Image>().color = newColor;
            yield return null;
        }

        SceneManager.LoadScene(phase2);
    */


}
