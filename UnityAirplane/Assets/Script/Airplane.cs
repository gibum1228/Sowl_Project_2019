using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : MonoBehaviour
{
    public GameObject airplane;
    Transform tr; // 포지션, 로케이션, 스케일 관리하는 변수 이름 Transform

    /* void Awake() // 처음에 생성되기 전에 한 번만 실행되는 문
    {
    } */
    // Start is called before the first frame update
    void Start()
    {
        tr = airplane.GetComponent<Transform>(); // tr에 airplane transform 컴퍼넌트를 가져온다
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            tr.position = new Vector3(tr.position.x, tr.position.y, tr.position.z + 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            tr.position = new Vector3(tr.position.x - 1, tr.position.y, tr.position.z);
            tr.rotation = Quaternion.Euler(tr.position.x - 10, 0, tr.position.z + 10);
        }
        if (Input.GetKey(KeyCode.S))
        {
            tr.position = new Vector3(tr.position.x, tr.position.y, tr.position.z - 1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            tr.position = new Vector3(tr.position.x + 1, tr.position.y, tr.position.z);
        }
    }
}
