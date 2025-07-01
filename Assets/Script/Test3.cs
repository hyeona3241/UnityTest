using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int num1 = 10;
        int num2 = 3;

        Debug.Log(num1 + "+" + num2 + "=" + (num1+num2));
        Debug.Log(num1 + "-" + num2 + "=" + (num1 - num2));
        Debug.Log(num1 + "*" + num2 + "=" + (num1 * num2));
        Debug.Log(num1 + "/" + num2 + "=" + (num1 / num2));
        Debug.Log(num1 + "%" + num2 + "=" + (num1 % num2));

        string firstName = "Park";
        string lastName = "HyeonA";
        string myName = firstName + lastName;
        Debug.Log(myName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
