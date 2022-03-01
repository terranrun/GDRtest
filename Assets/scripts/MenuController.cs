using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    enum Screen
    {
        ScoreMenu,
        RestartMenu
    }

    public CanvasGroup ScoreMenu;
    public CanvasGroup RestartMenu;

    private void SetCurrentScreen(Screen screen)
    {
        Utility.SetCanvasGroupEnabled(ScoreMenu, screen == Screen.ScoreMenu);
        Utility.SetCanvasGroupEnabled(RestartMenu, screen == Screen.RestartMenu);
    }

    private void Start()
    {
        SetCurrentScreen(Screen.ScoreMenu);
    }
    public void RestartMenuPanel()
    {
        SetCurrentScreen(Screen.RestartMenu);
    }
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
