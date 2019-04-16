using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createMiniGame : MonoBehaviour
{
    public enum Operation {add, subtract, multiply, divide};

    public string[] names = new string[12];
    public string[] verbs = new string[12];
    public string[] nouns = new string[12];
    Operation op;
    public int correctAnswer;
    public int[] answers = new int[4];
    public int leftOperand;
    public int rightOperand;
    // Start is called before the first frame update
    void Start()
    {
        setOperands();
        setOperation();
        solve();
        Debug.Log(correctAnswer);
    }

    public void setOperands()
    {
        leftOperand = Random.Range(0, 12);
        if(op != Operation.divide)
        {
            rightOperand = Random.Range(0, 12);
        }
        else 
        {
            rightOperand = Random.Range(0, 12);
        }
    }

    public void setOperation()
    {
        int rand;
        rand = Random.Range(1,4);
        switch (rand)
        {
            case 1:
                op = Operation.add;
                break;
            case 2:
                op = Operation.subtract;
                break;
            case 3: 
                op = Operation.multiply;
                break;
            case 4:
                op = Operation.divide;
                break;
        }   

    }

    public void setNames()
    {
        names[0] = "James";
        names[1] = "Samantha";
        names[2] = "Tristan";
        names[3] = "Alex";
        names[4] = "Alexander";
        names[5] = "Jasmine";
        names[6] = "Tyler";
        names[7] = "Tori";
        names[8] = "Hannah";
        names[9] = "India";
        names[10] = "Reily";
        names[11] = "Jay";
        names[12] = "Ian";
    }

    public void setVerbs()
    {
        //SUBTRACTION VERBS
        verbs[0] = "sells";
        verbs[1] = "eats";
        verbs[2] = "loses";
        //ADDITION VERBS
        verbs[3] = "buys";
        verbs[4] = "is given";
        verbs[5] = "is gifted";
        //MULTIPLICATOIN VERBS
        verbs[6] = "";
        verbs[7] = "";
        verbs[8] = "";
        //DIVISION VERBS
        verbs[9] = "";
        verbs[10] = "";
        verbs[11] = "";
        verbs[12] = "";
    }

    public void setNouns()
    {
        nouns[0] = "apple";
        nouns[1] = "orange";
        nouns[2] = "watermelon";
        nouns[3] = "potatoe";
        nouns[4] = "melon";
        nouns[5] = "peppers";
        nouns[6] = "bunches of grape";
        nouns[7] = "grapefruit";
        nouns[8] = "pear";
        nouns[9] = "steak";
        nouns[10] = "clemintines";
        nouns[11] = "cheese stick";
        nouns[12] = "dragonfruit";
    }

    public void solve()
    {
        switch (op)
        {
            case Operation.add:
                Debug.Log("addition selected");
                correctAnswer = leftOperand + rightOperand;
                break;
            case Operation.subtract:
                Debug.Log("subtraction selected");
                correctAnswer = leftOperand - rightOperand;
                break;
            case Operation.multiply:
                Debug.Log("multiplication selected");
                correctAnswer = leftOperand * rightOperand;
                break;
            case Operation.divide:
                Debug.Log("divison selected");
                if (rightOperand == 0)
                {
                    Debug.Log("Division by zero is not allowed");  
                }
                else
                {
                    correctAnswer = leftOperand / rightOperand;
                }
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
