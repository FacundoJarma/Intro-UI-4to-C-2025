using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Ejercicio6 : MonoBehaviour
{
    [SerializeField] TMP_InputField numInput;
    [SerializeField] TextMeshProUGUI resultText;

    int num1;
    string message = "";
    public void evenOrOdd()
    {
        num1 = int.Parse(numInput.text);
        if(num1 % 2 == 0)
        {
            message = "es par.";
        }
        else
        {
            message = "es impar.";
        }

        resultText.text = "El numero " + message;
    }
}
