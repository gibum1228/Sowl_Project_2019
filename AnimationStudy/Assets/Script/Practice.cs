using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{

    bool __a = true;
    float _time = 0;

    void Start()
    {

       
    }

    void Update()
    {

        _time += Time.smoothDeltaTime;

        if(_time > 1f && __a == true)
        {
            __a = false;
            if (IsInvoking("gibum") == false)
            {
                Invoke("gibum", 1);
            }

        }
    }
    void gibum()
    {
          
    }

    IEnumerator aa()
    {
        yield return 0;
    }
}
