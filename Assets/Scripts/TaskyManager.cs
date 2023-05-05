using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TaskyManager : MonoBehaviour
{
    public List<Task> allTasks = new List<Task>();
    List<Task> availableTasks = new List<Task>();

    public AudioSource audioSource;
    LevelProperties levelProperties;

    public GameObject letterBackground;
    public GameObject chooseTaskTitle;
    public GameObject taskButton;
    public GameObject canvas;
    int[] yButtonOffsets = {100, 20, -60, -140};

    // Start is called before the first frame update
    void Initiate()
    {
        levelProperties = GameObject.Find("LevelProperties").GetComponent<LevelProperties>();
        LoadTasks();
        foreach (Task task in allTasks) {
            if ((task.difficultyLevel <= levelProperties.GetLevel())) {
                availableTasks.Add(task);
            }
        }
    }

    public void playSoundEffect() {
        audioSource.Play();
    }

    Task[] selectKTasks(int k)
    {
        // index for elements in stream[]
        int i;
        Task[] reservoir = new Task[k];
        for (i = 0; i < k; i++)
            reservoir[i] = availableTasks[i];
        
        // Iterate from the (k+1)th
        // element to nth element
        for (; i < availableTasks.Count; i++)
        {
            // Pick a random index from 0 to i.
            int j = Random.Range(0, i + 1);
            if(j < k)
                reservoir[j] = availableTasks[i];    
        }

        return reservoir;
    }

    public void OpenMessageButton() {
        GameObject.Find("Open Message Button").SetActive(false);
        ShowTasks();
        playSoundEffect();

    }

    public void ShowTasks() {
        Initiate();
        Task[] tasks = selectKTasks(4);
        
        CreateLetterBackground();
        CreateTitle();
        for (int i = 0; i < 4; i++) {
            CreateTaskButton(i, tasks[i]);
        }
    }

    public void CreateLetterBackground() {
        letterBackground.SetActive(true);
    }
    public void CreateTitle() {
        GameObject title = Instantiate(chooseTaskTitle);
        title.transform.SetParent(canvas.transform, false);
    }

    public void CreateTaskButton(int i, Task task) {
        GameObject button = Instantiate(taskButton);
        button.transform.position += (Vector3.up * yButtonOffsets[i]);
        button.transform.SetParent(canvas.transform, false);
        TextMeshProUGUI text = button.GetComponentInChildren<TextMeshProUGUI>();
        ButtonProperties buttonProperties = button.GetComponent<ButtonProperties>();
        buttonProperties.setTask(task);
        text.SetText(task.description);
    }

    public void LoadTasks() {
        allTasks.Add(new Task{
            description = "Cry like a baby",
            difficultyLevel = 1,
            proficiency = "criative",
            isCompleted = false
        });
        allTasks.Add(new Task{
            description = "Explode the building",
            proficiency = "energy",
            difficultyLevel = 1,
            isCompleted = false
        });
        allTasks.Add(new Task{
            description = "Smell drugs and investigate",
            proficiency = "animal",
            difficultyLevel = 1,
            isCompleted = false
        });
        allTasks.Add(new Task{
            description = "Rust the electricity post",
            proficiency = "animal",
            difficultyLevel = 1,
            isCompleted = false
        });
        allTasks.Add(new Task{
            description = "Run complicated math equations",
            proficiency = "calm",
            difficultyLevel = 1,
            isCompleted = false
        });
        allTasks.Add(new Task{
            description = "Deliver a message",
            proficiency = "criative",
            difficultyLevel = 1,
            isCompleted = false
        });
        allTasks.Add(new Task{
            description = "Impose power over the world",
            proficiency = "energy",
            difficultyLevel = 1,
            isCompleted = false
        });
        allTasks.Add(new Task{
            description = "Organize a \"cleansing\"",
            proficiency = "calm",
            difficultyLevel = 1,
            isCompleted = false
        });
        allTasks.Add(new Task{
            description = "Plan an ambush for the rebelious young",
            proficiency = "calm",
            difficultyLevel = 1,
            isCompleted = false
        });
        allTasks.Add(new Task{
            description = "Retrieve the mysterious package",
            proficiency = "animal",
            difficultyLevel = 1,
            isCompleted = false
        });
        allTasks.Add(new Task{
            description = "Navigate the tight tunnels",
            proficiency = "animal",
            difficultyLevel = 1,
            isCompleted = false
        });
        allTasks.Add(new Task{
            description = "Spy on the younglings",
            proficiency = "creative",
            difficultyLevel = 1,
            isCompleted = false
        });
        allTasks.Add(new Task{
            description = "Disrupt the rebels",
            proficiency = "energy",
            difficultyLevel = 1,
            isCompleted = false
        });
        allTasks.Add(new Task{
            description = "Express your dreams",
            proficiency = "creative",
            difficultyLevel = 1,
            isCompleted = false
        });
        allTasks.Add(new Task{
            description = "Think",
            proficiency = "calm",
            difficultyLevel = 1,
            isCompleted = false
        });
        allTasks.Add(new Task{
            description = "Disrupt the government's power supply",
            proficiency = "energy",
            difficultyLevel = 1,
            isCompleted = false
        });
    }
}
