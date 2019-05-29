using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveHome : MonoBehaviour
{
    public GameObject HomeBtn;

    public void moveHome()
    {
        SceneManager.LoadScene(0);
    }
}
