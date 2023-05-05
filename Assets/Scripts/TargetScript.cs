using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    private void OnMouseDown()
    {
        ShoterGame.Instance.KillChange(1);
        gameObject.SetActive(false);
    }
}
