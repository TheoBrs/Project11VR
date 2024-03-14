using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.XR.Content.Interaction;

public class GameManager : MonoBehaviour
{
    public AudioSource destroySound;
    public GameObject particlePrefab;
    [SerializeField] GameDoor door;
    List<int> DoorCode = new List<int> { 1, 3, 2, 3 };
    List<int> TestCode = new List<int> ();
    public bool CodeValid = false;
    public bool KeyValid = false;  
    GameManager Instance;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else if (Instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(this);
    }
    private void Update()
    {
        if (CodeValid && KeyValid)
        {
            //Debug.Log("youpi");
            
        }
    }

    public void BarrelBreak()
    {
        //Play particles
        Instantiate(particlePrefab);
        //Play sound
        destroySound.Play();
    }

    public void Button1()
    {
        int Length = TestCode.Count;
        int button = 1;
        if (DoorCode[Length] == button) 
        {
            TestCode.Add(button);
            Debug.Log("oui");
        }
        else
        {
            TestCode.Clear();
        }
        if (TestCode.Count == DoorCode.Count)
        {
            CodeValid = true;
            Debug.Log("Zeub");
        }
    }

    public void Button2()
    {
        int Length = TestCode.Count;
        int button = 2;
        if (DoorCode[Length] == button)
        {
            TestCode.Add(button);
            Debug.Log("Non");
        }
        else
        {
            TestCode.Clear();
        }
        if (TestCode.Count == DoorCode.Count)
        {
            CodeValid = true;
            Debug.Log("Zeub");
        }
    }

    public void Button3()
    {
        int Length = TestCode.Count;
        int button = 3;
        if (DoorCode[Length] == button)
        {
            TestCode.Add(button);
            Debug.Log("Fock");
        }
        else
        {
            TestCode.Clear();
        }
        if (TestCode.Count == DoorCode.Count)
        {
            CodeValid = true;
            Debug.Log("Zeub");
        }
    }

    public void Button4()
    {
        int Length = TestCode.Count;
        int button = 4;
        if (DoorCode[Length] == button)
        {
            TestCode.Add(button);
        }
        else
        {
            TestCode.Clear();
            Debug.Log("Cheh");
        }
        if (TestCode.Count == DoorCode.Count)
        {
            CodeValid = true;
            Debug.Log("Zeub");
        }
    }

    public void Key()
    {
        KeyValid = true;
    }

    public void noKey()
    {
        KeyValid=false;
    }

}
