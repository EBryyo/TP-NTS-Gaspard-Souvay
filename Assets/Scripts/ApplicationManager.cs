using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationManager : MonoBehaviour
{

    private int maxBalls = 5;
    private float spawnRate = 1;
    public GameObject ballPrefab;
    private float spawnRange = 5f;
    public Transform cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Ball").Length;
        if (count < maxBalls && (count/maxBalls) * Random.Range(0,10) < spawnRate)
        {
            float x = cam.transform.position.x + Random.Range(-spawnRange, spawnRange);
            float y = cam.transform.position.y + Random.Range(0, spawnRange);
            float z = cam.transform.position.z + Random.Range(spawnRange/2, spawnRange);
            Vector3 spawnPos = new Vector3(x, y, z);
            Instantiate(ballPrefab, spawnPos, Quaternion.identity);
        }
    }
}
