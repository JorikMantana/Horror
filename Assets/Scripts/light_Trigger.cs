using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_Trigger : MonoBehaviour
{
    public GameObject tD2;
    public GameObject tM6;
    public GameObject tM7;
    public GameObject TriggerBox;
    public GameObject TriggerBox_ElRoom;
    public GameObject TapE;
    public bool inTrigger = false;

    void Start()
    {
        TriggerBox_ElRoom.SetActive(false);

    }
    public void OnTriggerEnter(Collider col)
    {
        TapE.SetActive(true);
        inTrigger = true;
    }
    public void OnTriggerExit()
    {
        TapE.SetActive(false);
        inTrigger = false;
    }
    void Update()
    {
        if(inTrigger == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                tD2.SetActive(true);
                tM6.SetActive(false);
                tM7.SetActive(true);
                Invoke("off_tD", 3);
                TapE.SetActive(false);
            }
        }
    }
    public void off_tD()
    {
        tD2.SetActive(false);
        TriggerBox_ElRoom.SetActive(true);
        Destroy(TriggerBox);
    }
}
