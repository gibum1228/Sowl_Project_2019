using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeAniamtior : MonoBehaviour
{
    Animator Anim;

    void Start()
    {
        Anim = GetComponent<Animator>();
        StartCoroutine(anims());
    }

    IEnumerator anims()
    {
        yield return new WaitForSeconds(3);
        Anim.SetBool("gibum",true);


        yield return 0;
    }
}
