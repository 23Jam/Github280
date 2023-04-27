using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float strafe;
    float forward;
    float turn;
    float speed = 6f;
    float turnSpeed = 10f;

    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        strafe = Input.GetAxis("Horizontal");
        forward = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(strafe, 0, forward) * speed * Time.deltaTime);

        turn = Input.GetAxis("Mouse X");

        transform.rotation *= Quaternion.Slerp(Quaternion.identity, Quaternion.LookRotation(turn < 0 ? Vector3.left : Vector3.right), Mathf.Abs(turn) * turnSpeed * Time.deltaTime);

        //Syncs up the forward value from player input to the forward property in the animation controller
        anim.SetFloat("ForwardMovement", forward);
    }
}
