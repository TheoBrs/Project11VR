using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void MenuToRule()
    {
        SceneManager.LoadScene(1);
    }

    public void RuleToGame()
    {
        SceneManager.LoadScene(2);
    }

    public void GameToWin()
    {
        SceneManager.LoadScene(3);
    }

    public void GameToLoose()
    {
        SceneManager.LoadScene(4);
    }

    public void MenuToSettings()
    {
        SceneManager.LoadScene(5);
    }

    public void SettingsToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
