using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class startMinigame : MonoBehaviour
{

    public float targetTime = 10.0f;

    void Update()
    {

        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }

    }

    void timerEnded()
    {
        SceneManager.LoadScene("minigame");
    }


}
