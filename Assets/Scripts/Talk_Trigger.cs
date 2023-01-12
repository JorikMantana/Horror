using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Talk_Trigger : MonoBehaviour
{
    public GameObject Panel;
    public GameObject hiText;
    public GameObject Text;
    public bool inTrigger = false;
    public Transform Guy;
    public GameObject Camera;
    public GameObject tM2;
    public GameObject TriggerBox;
    public CinemachineVirtualCamera cinema;
    public Transform Gay;
    public GameObject Camera_2;
    public GameObject Camera_1;
    public GameObject Player;

    void Start()
    {
        Text.SetActive(false);
        Panel.SetActive(false);
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            Text.SetActive(true);
            inTrigger = true;
        }
    }

    void OnTriggerExit()
    {
        Text.SetActive(false);
        inTrigger = false;
    }

    void Update()
    {
        if(inTrigger == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Panel.SetActive(true);
                hiText.SetActive(false);
                Text.SetActive(false);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                Move.move.enabled = false;
                tM2.SetActive(false);
                cinema.gameObject.SetActive(false);
                cinema.transform.LookAt(Gay);
                Camera_2.SetActive(true);
                Camera_1.SetActive(false);
                Player.SetActive(false);

            }
        }
    }

    public void offDialog()
    {
        Panel.SetActive(false);
        Cursor.visible = false;
        Move.move.enabled = true;
        Destroy(TriggerBox);
        cinema.gameObject.SetActive(true);
        Camera_1.SetActive(true);
        Camera_2.SetActive(false);
        Player.SetActive(true);
    }
}
