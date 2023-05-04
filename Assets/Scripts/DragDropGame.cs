using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDropGame : MonoBehaviour
{
    static public DragDropGame Instance;

    public int dropCount;
    private int onCount = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void DropChange(int points)
    {
        onCount = onCount + points;
        if (onCount == dropCount)
        {
            gameObject.SetActive(false);
        }
    }
}
