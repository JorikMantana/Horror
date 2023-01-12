using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Work_Trigger : MonoBehaviour
{
    public GameObject TapE;
    public GameObject ThirdPanel;
    public GameObject HourText;
    public bool inTrigger = false;
    public GameObject Typers;
    public GameObject aliveBoss;
    public GameObject deadBoss;
    public GameObject office_Sound;
    public GameObject default_Directionlight;
    public GameObject dark_Directionlight;
    public GameObject light;
    public GameObject TriggerBox;
    public GameObject tM5;
    public GameObject tD1;
    public GameObject tM6;
    public GameObject TriggerBox_light;

    void Start()
    {
        TapE.SetActive(false);
        TriggerBox_light.SetActive(false);
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            TapE.SetActive(true);
            inTrigger = true;
        }
    }
    void OnTriggerExit()
    {
        TapE.SetActive(false);
        inTrigger = false;
    }
    void Update()
    {
        if (inTrigger == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                ThirdPanel.SetActive(true);
                Invoke("onHourText", 1);
                Invoke("offPanel", 5);
                Typers.SetActive(false);
                aliveBoss.SetActive(false);
                deadBoss.SetActive(true);
                office_Sound.SetActive(false);
                default_Directionlight.SetActive(false);
                dark_Directionlight.SetActive(true);
                tM5.SetActive(false);
                TapE.SetActive(false);
            }
        }
    }
    public void onHourText()
    {
        HourText.SetActive(true);
    }
    public void offPanel()
    {
        ThirdPanel.SetActive(false);
        Destroy(TriggerBox);
        tD1.SetActive(true);
    }
    public void off_tD()
    {
        tD1.SetActive(false);
        tM6.SetActive(true);
        TriggerBox_light.SetActive(true);
    }
  
}
