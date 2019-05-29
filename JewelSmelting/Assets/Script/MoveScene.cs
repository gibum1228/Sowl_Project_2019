using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    public GameObject WorkBtn;
    public GameObject JuBtn;
    public GameObject JcBtn;
    public GameObject AbillityBtn;
    public GameObject InventoryBtn;

    public void moveWorkChoice()
    {
        SceneManager.LoadScene(5);
    }
    public void moveJU()
    {
        SceneManager.LoadScene(3);
    }
    public void moveJC()
    {
        SceneManager.LoadScene(2);
    }
    public void moveAbillity()
    {
        SceneManager.LoadScene(1);
    }
    public void moveInven()
    {
        SceneManager.LoadScene(6);
    }

}
