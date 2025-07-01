using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test4 : MonoBehaviour
{
    [SerializeField] bool isPlayingGuitar;
    [SerializeField] int age;
    public bool isPlaying;

    // Start is called before the first frame update
    void Start()
    {
        if(isPlayingGuitar == true)
        {
            Debug.Log("기타 연주 중 띵띵띵~");
        }
        else
        {
            Debug.Log("기타 연주 안하는 중...");
        }

        if(age == 20)
        {
            Debug.Log("대학교 신입생이군요!");
        }
        else if(age >= 21)
        {
            Debug.Log("대학교 신입생이 아니군요!");
        }
        else
        {
            Debug.Log("어린 친구");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
