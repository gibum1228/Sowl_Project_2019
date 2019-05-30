using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeItem : MonoBehaviour
{
    public List<Item> itemUpgrade = new List<Item>();           // 업그레이드 할 아이템 정보 담을 itemUpgrade, 한 개만 담을 수 있음

    public GameObject UpgradeInven;         // 업그레이드 할 아이템 올릴 창, Upgrade_Back
    public GameObject UpgradeBtn;           // 업그레이드 버튼
    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void upgradeItem()           // 업그레이드 버튼 클릭시
    {
        // 업그레이드 할 아이템 받아오기
        if (Slot.slot.Pop())            //  UpgradeInven에 Pop()이 실행이 되면 -> 참, 아마도 참인지 거짓인지만 검사?
        {
            itemUpgrade.Add(Slot.slot.Pop());           // itemgrade에 Pop()으로 값 반환 후 UpgradeInven에서 제거시킴
        }
        else
        {
            // 아이템 올려달라는 문구 출력
            Debug.Log(12412412);
        }

        // 강화 확률
        if(itemUpgrade[0].itemLevel <= 5)
        {
            if(Random.Range(1,101) <= 70)
            {
                itemUpgrade[0].itemLevel += 1;
            }
        }
        if (itemUpgrade[0].itemLevel <= 10)
        {
            if (Random.Range(1, 101) <= 50)
            {
                itemUpgrade[0].itemLevel += 1;
            }
        }
        if (itemUpgrade[0].itemLevel <= 15)
        {
            if (Random.Range(1, 101) <= 30)
            {
                itemUpgrade[0].itemLevel += 1;
            }
            else
            {
                itemUpgrade[0].itemLevel -= 1;
            }
        }
        if (itemUpgrade[0].itemLevel <= 15)         // 최대 16강까지 가능
        {
            if (Random.Range(1, 101) == 1)
            {
                itemUpgrade[0].itemLevel += 1;
            }
            else if(Random.Range(1, 101) == 100)
            {
                itemUpgrade.RemoveAt(0);
            }
            else
            {
                itemUpgrade[0].itemLevel -= 1;
            }
        }
    }
}
