using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;

public class MenuUIManger : MonoBehaviour
{
    private const float FontSizeMult = 0.05f;
    private bool mWaitingForAuth = false;
    private string mStatusText = "Ready.";

    // Start is called before the first frame update
    void Start()
    {
        GooglePlayGames.PlayGamesPlatform.Activate();
    }

    void AttemptLogIn()
    {
        if (!Social.localUser.authenticated)
        {
            // Authenticate
            mWaitingForAuth = true;
            mStatusText = "Authenticating...";
            Social.localUser.Authenticate((bool success) =>
            {
                mWaitingForAuth = false;
                if (success)
                {
                    mStatusText = "Welcome " + Social.localUser.userName;
                }
                else
                {
                    mStatusText = "Authentication failed.";
                }
            });
        }
        else
        {
            // Sign out!
            mStatusText = "Signing out.";
            ((GooglePlayGames.PlayGamesPlatform)Social.Active).SignOut();
        }
    }

    void OnGUI()
    {
        Rect buttonRect = new Rect(0.25f * Screen.width, 0.10f * Screen.height,
                         0.5f * Screen.width, 0.25f * Screen.height);
        Rect imageRect = new Rect(buttonRect.x + buttonRect.width / 4f,
                                  buttonRect.y + buttonRect.height * 1.1f,
                                  buttonRect.width / 2f, buttonRect.width / 2f);

        GUI.Label(new Rect(20, 20, Screen.width, Screen.height * 0.25f),
                  mStatusText);


        if (mWaitingForAuth)
        {
            return;
        }

        if (Social.localUser.authenticated)
        {
            if (Social.localUser.image != null)
            {
                GUI.DrawTexture(imageRect, Social.localUser.image,
                    ScaleMode.ScaleToFit);
            }
            else
            {
                GUI.Label(imageRect, "No image available");
            }

            mStatusText = "Ready";
        }





    }

    // Update is called once per frame
    void Update()
    {

    }

    //Play Button
    public void Play()
    {

        SceneManager.LoadScene("board2");


    }

    //Options Button
    public void Options()
    {

        SceneManager.LoadScene("options");

    }

    //MainMenu
    public void GoBack()
    {

        SceneManager.LoadScene("Menu");
    }

}
