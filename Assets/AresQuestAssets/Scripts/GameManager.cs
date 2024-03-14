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
}
