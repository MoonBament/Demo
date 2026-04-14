using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject enemyfire;
    public GameObject enemybullet;
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > 0.18f)
        {
            t = 0;
            GameObject obj = Instantiate(enemybullet );
            obj.transform.position = enemyfire.transform.position;
        }
    }
}
