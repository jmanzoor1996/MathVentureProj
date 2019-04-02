using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    private static GameObject player1, player2;

    public static int diceRoll = 0;
    public static int playerStart;

    // Start is called before the first frame update
    void Start()
    {
        player1 = GameObject.Find("spritereal");
        playerStart = player1.GetComponent<Path>().waypoints.Length - 1;

        player1.GetComponent<Path>().moveable = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player1.GetComponent<Path>().waypointIndex > playerStart - diceRoll)
        {
            playerStart = player1.GetComponent<Path>().waypointIndex - 1;
        }

        /*if (0 == player1.GetComponent<Path>().waypointIndex)
        {
         
        }*/
    }

    public static void MovePlayer(int player)
    {
        switch (player)
        {
            case 1:
                player1.GetComponent<Path>().moveable = true;
                break;
    }
    }
}
