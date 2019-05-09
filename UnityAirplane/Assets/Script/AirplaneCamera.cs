using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneCamera : MonoBehaviour
{
    public GameObject airplane;
    public GameObject airplaneCamera;

    Transform tr;
    Transform trCm;

    // Start is called before the first frame update
    void Start()
    {
        tr = airplane.GetComponent<Transform>();
        trCm = airplaneCamera.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        trCm.transform.position = Vector3.Lerp(trCm.transform.position, tr.transform.position + new Vector3(0,8,-15), 0.3f); // trcm에서 tr까지 1초안에 이동시킴
    }
}
