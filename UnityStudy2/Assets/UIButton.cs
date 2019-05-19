using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIButton : MonoBehaviour
{
    public GameObject goldText;
    public GameObject showText; // Text와 연결시켜 주기 위해 선언

    Text _goldText; // 텍스트 래퍼런스형 변수 (컴퍼넌트를 접근하기 위함)

    bool text_OnOff = false; // text 활성화 여부 판단하는 변수
    int gold = 0; // 골드량 변수

    public void showBox() // 버튼 누를 시 이벤트
    {
        if (text_OnOff == false){ // 꺼져있으면 키고
            showText.SetActive(true); // true는 활성화시키기, false는 비활성화시키기
            text_OnOff = true;
        }else if(text_OnOff == true){ // 커져있으면 끄고
            showText.SetActive(false); // true는 활성화시키기, false는 비활성화시키기
            text_OnOff = false;
        }
    }
    
    public void miningGold()
    {
        _goldText = goldText.GetComponent<Text>();
        gold += 5;
        _goldText.text = gold.ToString() + "g"; // 골드는 int형이기 떄문에 String으로 바꾼 후 _goldText 변경
    }
}
