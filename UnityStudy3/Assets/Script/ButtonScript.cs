using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void ScreenChange(int i)
    {
        if(i == 1)
        {
            SceneManager.LoadScene(1);
        }
        else
        {

        }
    }
}
