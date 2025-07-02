using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float intervalMin = 0.5f;
    public float intervalMax = 3f;

    private Transform target;
    private float interval;
    private float timeAfterSpawn;

    // Start is called before the first frame update
    void Start()
    {
        interval = Random.Range(intervalMin, intervalMax);
        timeAfterSpawn = 0f;

        ////target 지정하는 방법
        ////방법 1. 컴포넌트로 찾기
        //target = FindObjectOfType<Player>().transform;

        ////방법 2. 이름으로 찾기
        //target = GameObject.Find("Player").transform;

        //방법 3. 태그로 찾기
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;

        if (timeAfterSpawn >= interval)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.transform.LookAt(target);

            interval = Random.Range(intervalMin, intervalMax);
            timeAfterSpawn = 0f;
        }
    }
}
