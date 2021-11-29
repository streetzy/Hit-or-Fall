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
    //private GameObject[] targetArr;

    void Awake()
    {
        game.SetActive(false);
        menuManager.SetActive(true);
    }

    public void BeginGame()
    {
        menuManager.SetActive(false);
        game.SetActive(true);

        //targetArr = GameObject.FindGameObjectsWithTag("Target");
        //foreach (GameObject target in targetArr)
        //{
        //    Destroy(target);
        //} This part of the code doesn't work, recheck it later.
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
