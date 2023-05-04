using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMinigame : MonoBehaviour
{
    static public SwitchMinigame Instance;

    public int switchCount;
    private int onCount = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void SwitchChange(int points)
    {
        onCount = onCount + points;
        if (onCount == switchCount)
        {
            gameObject.SetActive(false);
        }
    }
}
