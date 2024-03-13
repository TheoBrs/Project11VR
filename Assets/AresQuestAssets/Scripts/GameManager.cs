using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public AudioSource destroySound;
    public GameObject particlePrefab;

    void Start()
    {

    }


    public void BarrelBreak()
    {
        //Play particles
        Instantiate(particlePrefab);
        //Play sound
        destroySound.Play();
    }

}