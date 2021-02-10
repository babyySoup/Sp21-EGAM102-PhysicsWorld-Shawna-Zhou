using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopNumber : MonoBehaviour
{
    //print out the odds to 99
    void Start()
    {
        string outputString = "";
        for(int i = 1; i < 100; i+=2)
        {
            outputString += i.ToString() + ", ";
        }
        Debug.Log(outputString);

        //Prints the fives from 55 to 255
        outputString = "";
        for (int i = 55; i < 256; i +=5)
        {
            outputString += i.ToString() + ", ";
        }
        Debug.Log(outputString);

        //print the evens from -100 to 0
        outputString = "";
        for (int i = -100; i < 1; i += 2)
        {
            outputString += i.ToString() + ", ";
        }
        Debug.Log(outputString);


        //print 10s from 10 to 100, alternating positive and negative
        outputString = "";
        for (int i = 0; i < 11; i++)
        {
            if (i%2 ==0)
            {
                int nextNumberToPrint = i * 10;
                outputString += nextNumberToPrint.ToString() + ", ";
            }
            else
            {
                int nextNumberToPrint = i * -10;
                outputString += nextNumberToPrint.ToString() + ", ";
            }
        }
        Debug.Log(outputString);
    }



}
