using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 1; i <= 10; i++)
        {
            Debug.Log("10 연속 배기 " +  i + "타!");
        }

        int fireTime = 5;
        while (fireTime > 0) 
        {
            Debug.Log("불이 붙어 피해 5를 입었다! (지속 시간 " + fireTime + "초 남음)");
            fireTime--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
