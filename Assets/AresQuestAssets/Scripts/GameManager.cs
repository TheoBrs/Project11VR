using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string sceneName;

    void Start()
    {

    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }

}
