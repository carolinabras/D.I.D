using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{

    public bool isOn = true;

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (isOn)
        {
            SwitchMinigame.Instance.SwitchChange(1);
        }
    }

    private void OnMouseUp()
    {
        isOn = !isOn;
        if (isOn)
        {
            SwitchMinigame.Instance.SwitchChange(1);
        }
        else
        {
            SwitchMinigame.Instance.SwitchChange(-1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isOn)
        {
            spriteRenderer.color = Color.green;
        }
        else
        {
            spriteRenderer.color = Color.red;
        }
    }
}
