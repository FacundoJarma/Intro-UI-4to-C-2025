using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Ejercicio5 : MonoBehaviour
{
    [SerializeField] TMP_InputField num1Input;
    [SerializeField] TMP_InputField num2Input;
    [SerializeField] TextMeshProUGUI resultText;

    float num1;
    float num2;
    float res;

    public void divide()
    {
        num1 = float.Parse(num1Input.text);
        num2 = float.Parse(num2Input.text);
        if(num2 == 0)
        {
            resultText.text = "No se puede dividir por cero";
            return;
        }
        res = num1 / num2;

        resultText.text = "La division entre " + num1 + " y " + num2 + " da como resultado " + res;
    }
}
