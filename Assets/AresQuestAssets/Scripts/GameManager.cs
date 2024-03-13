using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource destroySound;
    public GameObject particlePrefab;


    public void BarrelBreak()
    {
        //Play particles
        Instantiate(particlePrefab);
        //Play sound
        destroySound.Play();
    }

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
}
