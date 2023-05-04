using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonProperties : MonoBehaviour
{
    [SerializeField] Task task;

    public Task getTask() {
        return this.task;
    }
    public void setTask(Task task) {
        this.task = task;
    }
}
