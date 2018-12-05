using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool emMovimento, emMovimentoA, emMovimentoD, emMovimentoS;

        if (Input.GetKey(KeyCode.W))
        {
            emMovimento = true;

        }
        else
        {
            emMovimento = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            emMovimentoA = true;


        }
        else
        {
            emMovimentoA = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            emMovimentoD = true;


        }
        else
        {
            emMovimentoD = false;
        }
        if (Input.GetKey(KeyCode.S))
        {
            emMovimentoS = true;

        }
        else
        {
            emMovimentoS = false;
        }
        if (emMovimento)
        {

            anim.Play("HumanoidWalk");

        }
        else if (emMovimentoA)
        {

            anim.Play("HumanoidWalkLeft");

        }
        else if (emMovimentoD)
        {

            anim.Play("HumanoidWalkRight");

        }
        else if (emMovimentoS)
        {

            anim.Play("HumanoidWalk");

        }
        else
        {
            anim.Play("HumanoidIdle");
        }
        

    }
}
