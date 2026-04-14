using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    float t = 0;
    public float speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t = Time.time;//时间均匀累加
        print(t);
        GetComponent<MeshRenderer>().material.mainTextureOffset = new Vector2(0,t*speed);

       
    }
}
