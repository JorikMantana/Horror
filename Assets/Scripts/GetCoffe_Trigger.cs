using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCoffe_Trigger : MonoBehaviour
{
    public GameObject TapE;
    public GameObject SecondPanel;
    public GameObject tM4;
    public GameObject tM5;
    public GameObject lostCoffe;
    public bool inTrigger;
    public GameObject TriggerBox;
    public GameObject cinema;
    public GameObject Camera_1;
    public GameObject Camera_2;
    public GameObject Player;


    void Start()
    {
        inTrigger = false;
    }


    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            inTrigger = true;
            TapE.SetActive(true);
        }
    }

    void OnTriggerExit()
    {
        inTrigger = false;
        TapE.SetActive(false);
    }


    void Update()
    {
        if(inTrigger == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                SecondPanel.SetActive(true);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                Move.move.enabled = false;
                tM4.SetActive(false);
                TapE.SetActive(false);
                cinema.SetActive(false);
                Camera_2.SetActive(true);
                Camera_1.SetActive(false);
                Player.SetActive(false);

            }
        }
    }

    public void offDialog()
    {
        SecondPanel.SetActive(false);
        Cursor.visible = false;
        Move.move.enabled = true;
        tM5.SetActive(true);
        lostCoffe.SetActive(true);
        Invoke("off_lostCoffe", 2);
        cinema.SetActive(true);
        Camera_1.SetActive(true);
        Camera_2.SetActive(false);
        Player.SetActive(true);
    }

    public void off_lostCoffe()
    {
        lostCoffe.SetActive(false);
        Destroy(TriggerBox);
    }

}
