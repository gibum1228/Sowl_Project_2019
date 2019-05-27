using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateItem : MonoBehaviour
{
    public GameObject item_prefebs;

    void Start()
    {
        for(int i = 0; i < 12; i++)
        {
            GameObject sksk = Instantiate(item_prefebs);
            int x = Random.Range(-50, 50);
            int z = Random.Range(-50, 50);
            sksk.transform.position = new Vector3(x, 5, z);
        }
    }
}
