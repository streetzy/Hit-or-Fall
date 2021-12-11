using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSelection : MonoBehaviour
{
    private List<GameObject> menus = new List<GameObject>();
    public GameObject mainMenu;
    public GameObject scoreboard;
    public GameObject menuManager;
    public GameObject game;
    public GameObject enemyManager;
    public GameObject fallingObject;
    private GameObject child;
    public TargetSpawning targetSpawning;


    // Once the script is being loaded, set the game's activity in the hierarchy to false, while setting the menu manager's activity to true.
    void Awake()
    {
        game.SetActive(false);
        menuManager.SetActive(true);
    }

    // Sets the falling object's y position to 100, and sets game's activity to true (menu to false), then destroy's all enemies that were still loaded in from the previous playthrough.
    // Starts the coroutine (spawning targets) from target spawning.
    public void BeginGame()
    {
        fallingObject.transform.position = new Vector3(0, 100, 0);
        menuManager.SetActive(false);
        game.SetActive(true);
        for (int i = 0; i < enemyManager.transform.childCount ; i++ )
        {
            child = enemyManager.transform.GetChild(i).gameObject;
            Destroy(child);
        }
        StartCoroutine(targetSpawning.SpawnTargets());
    }

    // Activating scoreboard menu, adding both menus to a menu list.
    public void ScoreboardMenu()
    {
        mainMenu.SetActive(false);
        scoreboard.SetActive(true);
        menus.Add(mainMenu);
        menus.Add(scoreboard);
    }

    // Activates the previous menu (0th index) while disabling the 1st index, then clears the list for further use.
    public void Back()
    {
        menus[0].SetActive(true);
        menus[1].SetActive(false);
        menus.Clear();
    }

    // Exits out of the unity editor playing app.
    public void Exit() 
    {
        UnityEditor.EditorApplication.isPlaying = false;
        // Application.Quit();
    }

}
