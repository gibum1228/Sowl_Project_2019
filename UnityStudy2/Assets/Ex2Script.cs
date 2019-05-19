using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex2Script : MonoBehaviour
{
    public GameObject ready_t;
    public GameObject steady_t;
    public GameObject Bang_t;
    public GameObject win_t;
    public GameObject lose_t;
    
    float time = 0f; // 시간 초기화
    bool play = true; // 게임 가능 여부 판단

    // Update is called once per frame
    void Update() // 무한 반복문
    {   if (play == true)
        {
            time += Time.deltaTime; // 엔진이 한 바퀴 도는 작동의 시간을 저장(프로그램 시작하고 시간 재기)
        }

        if(time > 1f && time < 2f) // 초마다 알맞은 텍스트 출력
        {
            ready_t.SetActive(true);
        }else if(time > 2f && time < 3.5f)
        {
            ready_t.SetActive(false);
        }
        else if (time > 3.5f && time < 4.5f)
        {
            steady_t.SetActive(true);
        }
        else if (time > 4.5f && time < 6f)
        {
            steady_t.SetActive(false);
        }else if(time > 6f && time < 7f)
        {
            Bang_t.SetActive(true);

            if (Input.GetMouseButtonDown(0)) // 마우스 클릭시
            {
                win_t.SetActive(true);
                Bang_t.SetActive(false);
                play = false;
                time = 0;
            }
        }else if(time > 7)
        {
            Bang_t.SetActive(false);
            lose_t.SetActive(true);
            play = false;
        }
    }
}
