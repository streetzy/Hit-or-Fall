using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSelection : MonoBehaviour
{
    private List<GameObject> menus = new List<GameObject>();
    public GameObject mainMenu;
    public GameObject scoreboard;
    public GameObject menuManager;
    public GameObject game;

    public void BeginGame()
    {
        menuManager.SetActive(false);
        game.SetActive(true);
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
