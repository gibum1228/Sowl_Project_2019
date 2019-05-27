using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharaterMove : MonoBehaviour
{
    public GameObject Score_text;
    Text score_text;

    public int gameScore;

    public GameObject Character;
    public int speed = 10;

    Rigidbody char_rigd;
    Transform char_tr;

    void Awake()
    {
        score_text = Score_text.GetComponent<Text>();
        gameScore = 0;

        score_text.text = "Score : " + gameScore.ToString();

        // char_tr = Character.GetComponent<Transform>();
        char_rigd = Character.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey(KeyCode.W))
        {
            char_tr.transform.Translate(new Vector3(0, 0, 1));
        }
        if (Input.GetKey(KeyCode.A))
        {
            char_tr.transform.Translate(new Vector3(-1, 0, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            char_tr.transform.Translate(new Vector3(0, 0, -1));
        }
        if (Input.GetKey(KeyCode.D))
        {
            char_tr.transform.Translate(new Vector3(1, 0, 0));
        }
        */
        if (Input.GetKey(KeyCode.W))
        {
            char_rigd.AddForce(new Vector3(0, 0, 120) * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            char_rigd.AddForce(new Vector3(-120, 0, 00) * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            char_rigd.AddForce(new Vector3(0, 0, -120) * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            char_rigd.AddForce(new Vector3(120, 0, 0) * speed);
        }
    }
    
    void OnTriggerEnter(Collider x)
    {
        if(x.tag == "item")
        {
            gameScore++;

            score_text.text = "Score : " + gameScore.ToString();
        }
    }
}
