using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] skzoo;
    private float spawnX = 7.6f;
    private float spawnZ = -1.6f;
    private int index; //индекс массива
    private int delay = 3;
    private int spawnInterval = 2;
    void Start()
    {
        InvokeRepeating("sra", delay, spawnInterval);
    }
    void sra()
    { 
    index = Random.Range(0, skzoo.Length);//рандомно добавл€ем скзу индекс
        Vector3 pos = new Vector3(Random.Range(-spawnX,spawnX), 0,spawnZ);
        Instantiate(skzoo[index], pos, skzoo[index].transform.rotation);
    }
}
