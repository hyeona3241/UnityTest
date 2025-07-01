using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] numArr = new int[3];
        numArr[0] = 1;
        numArr[1] = 2;
        numArr[2] = 3;
        for (int i = 0; i < numArr.Length; i++)
        {
            Debug.Log("numArr[" + i + "] = " + numArr[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
