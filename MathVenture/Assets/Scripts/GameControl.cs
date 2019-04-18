using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    private static GameObject player1, player2;

<<<<<<< HEAD
    public static int diceRoll = 0;
    public static int playerStart;
=======
    public static int diceRoll;
    public static int playerStart;
    public static int count;

    public static bool GameOver = false;



>>>>>>> master

    // Start is called before the first frame update
    void Start()
    {
        player1 = GameObject.Find("spritereal");
<<<<<<< HEAD
        playerStart = player1.GetComponent<Path>().waypoints.Length - 1;

        player1.GetComponent<Path>().moveable = false;
=======
        playerStart = player1.GetComponent<Path>().waypointIndex;
        player1.GetComponent<Path>().moveable = false;


>>>>>>> master
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        if (player1.GetComponent<Path>().waypointIndex > playerStart - diceRoll)
        {
            playerStart = player1.GetComponent<Path>().waypointIndex - 1;
        }

        /*if (0 == player1.GetComponent<Path>().waypointIndex)
        {
         
        }*/
    }

    public static void MovePlayer(int player)
=======
        if (playerStart > player1.GetComponent<Path>().waypointIndex)
                playerStart = player1.GetComponent<Path>().waypointIndex;


    }

    public static void Modify(int num)
    {
        if (player1.GetComponent<Path>().waypointIndex > playerStart - num)
        {
            player1.GetComponent<Path>().waypointIndex -= num;
            player1.GetComponent<Path>().moveable = true;
        }
        

    }

    /*public static void MovePlayer(int player)
>>>>>>> master
    {
        switch (player)
        {
            case 1:
                player1.GetComponent<Path>().moveable = true;
<<<<<<< HEAD
                break;
    }
    }
=======
                player1.GetComponent<Path>().Move();

                break;
    }
    }*/
>>>>>>> master
}
