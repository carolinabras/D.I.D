using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskIGNORE : MonoBehaviour
{

    public string taskDescription;
    public int taskID;
   
   public bool isCompleted; // if the task is completed or not

    public string proficiency; // the proficiency that this task is associated with
    
    public TaskIGNORE(string description, int id)
    {
        taskDescription = description;
        taskID = id;
        isCompleted = false;
    }

    public void CompleteTask()
    {
        isCompleted = true;
    }
    
}
