using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SayTrigger : MonoBehaviour
{
    public GameObject Text;
    public GameObject tM1;
    public GameObject tM2;
    public GameObject TriggerBox;

    void Start()
    {
        Text.SetActive(false);
        tM1.SetActive(true);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Text.SetActive(true);
            Invoke("TextOff", 4);
            tM1.SetActive(false);
            tM2.SetActive(true);
        }
    }

    public void TextOff()
    {
        Text.SetActive(false);
        Destroy(TriggerBox);
    }
}
