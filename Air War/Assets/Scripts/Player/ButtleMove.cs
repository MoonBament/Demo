using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtleMove : MonoBehaviour
{
    GameObject canvas;
    public GameObject psenemy;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.Find("Canvas2");
    }
    private void OnTriggerEnter(Collider o)
    {
        if(o.gameObject .tag=="EnemyBullet" ){     //撞到敌机子弹即销毁

            Destroy(o.gameObject);
            canvas.GetComponent<GetScore>().Addscore(2);
            //GetScore.score += 2;
        }
        if (o.gameObject .tag=="Enemy")   //撞到敌机即销毁
        {
            Destroy(o.gameObject );
            Instantiate(psenemy ,o.gameObject .transform .position ,Quaternion.identity);
            canvas.GetComponent<GetScore>().Addscore(20);
            //GetScore.score += 20;
        }

        if (!o.gameObject .name .Contains ("player")&&o.gameObject .tag!= "Bullet"&&!o.gameObject .name .Contains ("goods") )
        {
            Destroy(o.gameObject);
        }
       
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0.18f, Space.World);   
        if(transform .position.z >10)
        {
            Destroy(this.gameObject);
        }
    }
}
