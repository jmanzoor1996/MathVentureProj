using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIManger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Play Button
    public void Play() {

        SceneManager.LoadScene("board2");


    }

    //Options Button
    public void Options() {

        SceneManager.LoadScene("options");

    }

    //MainMenu
    public void GoBack() {

        SceneManager.LoadScene("Menu");
    }

}
