using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Timer : MonoBehaviour
{
    public UnityEvent playerLost;

    public TMP_Text minutes;
    public TMP_Text seconds;

    public float totalTime = 900.0f;

    void Update()
    {
        if (totalTime > 0)
        {
            totalTime -= Time.deltaTime;
        }
        else if(totalTime <= 0)
        {
            playerLost.Invoke();
        }

        float min = Mathf.FloorToInt(totalTime / 60);
        float sec = Mathf.FloorToInt(totalTime % 60);

        double b = System.Math.Round(totalTime, 0);

        if (min < 10)
        {
            minutes.text = "0" + min.ToString();
        }
        else
        {
            minutes.text = min.ToString();
        }

        if (sec < 10)
        {
            seconds.text = "0" + sec.ToString();
        }
        else
        {
            seconds.text = sec.ToString();
        }

    }
}
