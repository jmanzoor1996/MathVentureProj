using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomGen : MonoBehaviour
{

    public GameObject TextBox;
    public int TheNumber;

    public void randomGenerator()
    {
        TheNumber = Random.Range(1, 7);

        TextBox.GetComponent<Text> ().text = "" + TheNumber;

    }

  
}
