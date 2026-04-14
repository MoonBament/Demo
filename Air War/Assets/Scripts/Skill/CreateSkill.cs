using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSkill : MonoBehaviour
{
    public GameObject[] skills = new GameObject[3];
    float t = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t>Random .Range (8,15))
        {
            t = 0;
            GameObject obj = Instantiate(skills[Random .Range (0,3)]);
            obj.transform.position = new Vector3(Random .Range (-3.02f,3.02f),1,6);
        }
    }
}
