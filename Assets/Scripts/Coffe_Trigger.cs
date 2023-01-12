using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffe_Trigger : MonoBehaviour
{
    public GameObject tapText;
    public bool inTrigger = false;
    public GameObject coffe;
    public GameObject tM3;
    public GameObject tM4;
    public GameObject TriggerBox;
    public GameObject GetCoffeTriggerBox;


    void OnTriggerEnter(Collider col)
    {
        tapText.SetActive(true);
        inTrigger = true;
    }

    void OnTriggerExit()
    {
        tapText.SetActive(false);
        inTrigger = false;
    }

    void Update()
    {
        if(inTrigger == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                tapText.SetActive(false);
                coffe.SetActive(true);
                Invoke("coffeOff", 2);
                tM3.SetActive(false);
                tM4.SetActive(true);
                GetCoffeTriggerBox.SetActive(true);
            }
        }
    }

    public void coffeOff()
    {
        coffe.SetActive(false);
        Destroy(TriggerBox);
    }
}
