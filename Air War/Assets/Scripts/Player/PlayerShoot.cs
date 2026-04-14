using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject[] firepos=new GameObject [5];
    public GameObject bullet;
    float t = 0;
    public Sprite[] sprites = new Sprite[3];
    int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider o)   
    {
        if(o.gameObject .name.Contains("goods1"))
        {
            index = 1;        //吃到技能包切换玩家飞机类型
            GetComponent<PlayerHealth>().DamagePlayer(-10);   //玩家加血
        }

        if (o.gameObject.name.Contains("goods2"))
        {
            index = 2;
            GetComponent<PlayerHealth>().DamagePlayer(-20);
        }

        if (o.gameObject.name.Contains("goods3"))
        {
            index = 0;
            GetComponent<PlayerHealth>().DamagePlayer(-30);
        }

        GetComponent<SpriteRenderer>().sprite = sprites[index];
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t >= 0.2f)
        {
            t = 0;
            if (index == 0)
            {
                GameObject obj = Instantiate(bullet );
                obj.transform.position = firepos[0].transform.position;
            }

            if (index==1)
            {
                for(int i = 0; i < 3; i++)
                {
                    GameObject obj = Instantiate(bullet );
                    obj.transform.position = firepos[i].transform.position;
                }
            }

            if (index == 2)
            {
                for (int i = 1; i < 5; i++)
                {
                    GameObject obj = Instantiate(bullet );
                    obj.transform.position = firepos[i].transform.position;
                }
            }
        }
       
    }
}
