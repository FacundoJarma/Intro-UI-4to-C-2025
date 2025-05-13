using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public class calculadora : MonoBehaviour
{
    [SerializeField] TMP_InputField num1Input;
    [SerializeField] TMP_InputField num2Input;
    [SerializeField] TextMeshProUGUI resultText;

    int num1;
    int num2;
    int res;
    public void sum()
    {
        num1 = int.Parse(num1Input.text);
        num2 = int.Parse(num2Input.text);

        res = num1 + num2;

        resultText.text = "La suma entre " + num1 + " y " + num2 + " da como resultado " + res;
    }
}
