using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{   
    void OnTriggerEnter2D(Collider2D cl)    // 서로 겹쳤을 때
    {
        if(cl.tag == "Box")
        {
            Debug.Log("충돌했음");
        }
    }

    void OnCollisionEnters(Collider2D cl)    // 부딪혔을 때
    {

    }
}
