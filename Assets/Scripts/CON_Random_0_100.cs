using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CON_Random_0_100 : MonoBehaviour
    {
    int smallNumber = 20;
    int maxMediumNumber = 80;
    int bigNumber = 80;

    void Start()
    {


        int randomNumber = Random.Range(0, 100);
        Debug.Log(randomNumber);

        if (randomNumber < smallNumber)
        {
            print("This Number Is Small");

        }
        else if (randomNumber < maxMediumNumber)
        {
            print("This Number Is Medium");

        }
        else
        {
            print("This Number Is Big");

        }
    }

    
}
