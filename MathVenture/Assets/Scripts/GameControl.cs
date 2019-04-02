using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

    private static GameObject player1, player2;

    public static int diceRoll;
    public static int playerStart;
    public static int count;

    public static bool GameOver = false;


    // Start is called before the first frame update
    void Start()
    {
        player1 = GameObject.Find("spritereal");
        playerStart = player1.GetComponent<Path>().waypointIndex;
        player1.GetComponent<Path>().moveable = false;
        
    }

    // Update is called once per frame
    void Update()
    {
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
    {
        switch (player)
        {
            case 1:
                player1.GetComponent<Path>().moveable = true;
                player1.GetComponent<Path>().Move();

                break;
    }
    }*/
}
