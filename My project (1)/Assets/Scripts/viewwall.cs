using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class viewwall : MonoBehaviour
{
    public GameObject[] wall;
    private int nowWall;
    private float nextWallTime = 0f;
    private float preTime;
    void Start()
    {
        preTime = Time.time;
    }
    void Update()
    {
        if(Time.time - preTime > nextWallTime)
        {
            nowWall = Random.Range(0, 17);//�H����
            nextWallTime = Random.Range(6, 9);//5~10��@����
            Instantiate(wall[nowWall], new Vector3(0, 5, -40), wall[nowWall].transform.rotation);
            preTime = Time.time;
        }
    }
    
}
