using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider o)   //吃到技能包后技能包消失
    {
        if (o.gameObject.name.Contains("goods"))
        {
            Destroy(o.gameObject );
        }
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.Translate(h*speed, 0, v*speed,Space.World);

        if (transform.position.x < -3.08f)
        {
            transform.position = new Vector3(-3.08f, 1, transform.position.z);
        }
        if (transform.position.x > 3.04f)
        {
            transform.position = new Vector3(3.04f, 1, transform.position.z);
        }
        if (transform.position.z < -4.12f)
        {
            transform.position = new Vector3(transform.position.x, 1, -4.12f);
        }
        if (transform.position.z > 3.86f)
        {
            transform.position = new Vector3(transform.position.x, 1, 3.86f);
        }
    }
}
