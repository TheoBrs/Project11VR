using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Start()
    {

    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }

}
