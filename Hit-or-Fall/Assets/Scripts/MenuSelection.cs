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


    void Awake()
    {
        game.SetActive(false);
        menuManager.SetActive(true);
    }

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
    }

    public void ScoreboardMenu()
    {
        mainMenu.SetActive(false);
        scoreboard.SetActive(true);
        menus.Add(mainMenu);
        menus.Add(scoreboard);
    }

    public void Back()
    {
        menus[0].SetActive(true);
        menus[1].SetActive(false);
        menus.Clear();
    }

    public void Exit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        // Application.Quit();
    }

}