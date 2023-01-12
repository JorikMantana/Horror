using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;


public class Move_player : MonoBehaviour
{
    private Rigidbody player_armin;
    private Animator player_animation;
    public float speed = 100.0f;
    public float speed_rotation = 10.0f;
    void Start()
    {
        player_armin = GetComponent<Rigidbody>();
        player_animation = GetComponent<Animator>();

    }
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        UnityEngine.Vector3 player_main = new UnityEngine.Vector3(-v, 0, h);
        if(player_main.magnitude > Mathf.Abs(0.05f))
        transform.rotation = UnityEngine.Quaternion.Lerp(transform.rotation, UnityEngine.Quaternion.LookRotation(player_main),Time.deltaTime * speed_rotation);
        player_animation.SetFloat("speed", UnityEngine.Vector3.ClampMagnitude(player_main, 1).magnitude);
        player_armin.velocity = UnityEngine.Vector3.ClampMagnitude(player_main,1) * speed;
    }
}
