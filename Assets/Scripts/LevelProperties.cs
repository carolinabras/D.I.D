using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelProperties : MonoBehaviour
{
    [SerializeField] int level = 1;
    //[SerializeField] int levelUp = 4;

    public Task currentTask;

    public Task getCurrentTask() {
        return this.currentTask;
    }

    public void setCurrentTask(Task task) {
        this.currentTask = task;
    }

    public void IncreaseLevel() {
        level++;
    }

    public void DecreaseLevel() {
        level--;
    }

    public int GetLevel() {
        return level;
    }
    // Make this game object and all its transform children
    // survive when loading a new scene.
    void Awake() {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad (this);
    }
}
