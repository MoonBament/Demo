using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
    public GameObject[] enemys = new GameObject[3];
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 0.4f)
        {
            t = 0;
           GameObject enemy= Instantiate(enemys[Random .Range(0,3)]);
            enemy.transform.position = new Vector3(Random .Range (-3.17f,3.12f),1,6);
        }
    }
}
