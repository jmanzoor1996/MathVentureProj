using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool isGamePaused = false;

    public GameObject pauseMenuUI;

<<<<<<< HEAD
=======

    private void Start()
    {
        pauseMenuUI.SetActive(false);
    }

>>>>>>> master
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
                Resume();
            else
                Pause();
        }
    }

    public void Resume()
    {
<<<<<<< HEAD
        SceneManager.LoadScene("board2");
=======
        //SceneManager.LoadScene("board2");
>>>>>>> master
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    public void Pause()
    {
<<<<<<< HEAD
        SceneManager.LoadScene("PauseMenu");
=======
        //SceneManager.LoadScene("PauseMenu");
>>>>>>> master
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}
