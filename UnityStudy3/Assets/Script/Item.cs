using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    void OnTriggerEnter(Collider cl)
    {
        if(cl.tag == "Character")
        {
            Destroy(gameObject);  // gameObject는 자기 자신을 뜻함 + GameObject는 자료형
        }
    }
}
