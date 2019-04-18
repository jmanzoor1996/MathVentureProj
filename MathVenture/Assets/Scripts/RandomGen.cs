using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomGen : MonoBehaviour
{

    public GameObject TextBox;
    public bool coroutineAllowed = true;
    public static int TheNumber;

<<<<<<< HEAD
    public void RandomGenerator()
=======
    /*private void OnMouseDown()
>>>>>>> master
    {
         if(!GameControl.GameOver && coroutineAllowed)
        {
            StartCoroutine("Roll");
        }
    }*/

<<<<<<< HEAD
        TextBox.GetComponent<Text> ().text = "" + TheNumber;
        GameControl.diceRoll = TheNumber;

        GameControl.MovePlayer(1);
    }

    
=======

    public void Roll()
    {
        coroutineAllowed = false;
        TheNumber = Random.Range(1, 7);
        TextBox.GetComponent<Text>().text = "" + TheNumber;
        GameControl.diceRoll = TheNumber;
        //GameControl.MovePlayer(1);
        GameControl.Modify(TheNumber);
        coroutineAllowed = true;
        

    }
>>>>>>> master
}
