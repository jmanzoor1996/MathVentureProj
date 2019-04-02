using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomGen : MonoBehaviour
{

    public GameObject TextBox;
    public bool coroutineAllowed = true;
    public static int TheNumber;

    /*private void OnMouseDown()
    {
         if(!GameControl.GameOver && coroutineAllowed)
        {
            StartCoroutine("Roll");
        }
    }*/


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
}
