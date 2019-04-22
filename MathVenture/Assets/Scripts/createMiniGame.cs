﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class createMiniGame : MonoBehaviour
{
    private enum Operation {add, subtract, multiply, divide};
    public Text a_buttonText;
    public Text b_buttonText;
    public Text c_buttonText;
    public Text d_buttonText;
    private string question;
    Operation op;
    public int correctAnswer;
    public int[] answers = new int[4];
    private int leftOperand;
    private int rightOperand;
    Text questionText;

    // Start is called before the first frame update
    void Start()
    {
        setOperands();
        setOperation();
        solve();
        createStringQuestion();
        setQuestionText();
        Debug.Log(correctAnswer);
	setAnswers();
    }

    public void createStringQuestion()
    {
        string symbol = "";
        switch (op)
        {
            case Operation.add:
                symbol = "+";
                break;
            case Operation.subtract:
                symbol = "-";
                break;
            case Operation.multiply:
                symbol = "*";
                break;
            case Operation.divide:
                symbol = "/";
                break;
        }
        question = leftOperand + " " + symbol + " " + rightOperand + " = ?";
    }

    public void setQuestionText()
    {
        questionText = GetComponent<Text>();
        questionText.text = question;
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
            rightOperand = Random.Range(1, 12);
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

    //Solves the equation generated by this script and sets the correctAnswer
    //instance data.
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

    public void setAnswers()
    {
	int correct_pos;
	correct_pos = Random.Range(0, 3);
	answers[correct_pos] = correctAnswer;
	for( int i = 0; i < answers.Length; i++){
		if(i != correct_pos){ 
			if (correctAnswer != 0){
			answers[i] = Random.Range(((correctAnswer / 2) * -1), 
							(correctAnswer * 2));
			}
			if (correctAnswer == 0)
			{
			answers[i] = Random.Range(-144, 144);
			}
			if (correctAnswer == 1)
			{
			answers[i] = Random.Range(-50, 50);
			}
			if (answers[i] == correctAnswer){
				if(answers[i] + 1 != 144){
					answers[i]++;
				}
				else{

					answers[i]--;
				}
			}
		}

	}
	
	int left;
	int right;
	for(int i = 0; i < answers.Length; i++)
	{
		left = answers[i];
		for(int j = 0; j < answers.Length; j++)
		{
			right = answers[j];
			if(j != correct_pos)
			{
				if(left == right)
				{
					if(left == 144){
						left = left - 1;
					}
					if(left == -144){
						left = left + 1;
					}
					else{
						left = left + 1;
					}
				}
			}
		}
	}		
	a_buttonText.text = answers[0].ToString();
	b_buttonText.text = answers[1].ToString();
	c_buttonText.text = answers[2].ToString();
	d_buttonText.text = answers[3].ToString();	
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
