﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Gun : MonoBehaviour
{
    public GameObject rocket;
    public float speed = 20f;
    PlayerCtrl playerCtrl;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        playerCtrl = transform.root.GetComponent<PlayerCtrl>();
        anim = transform.root.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (EventSystem.current.IsPointerOverGameObject()) return;
            //GetComponent<AudioSource>().play();
            anim.SetTrigger("shooting");
            if (playerCtrl.bFaceRight)
            {
                GameObject bulletInstance = Instantiate(rocket, transform.position, Quaternion.Euler(0, 0, 0));
                Rigidbody2D bi = bulletInstance.GetComponent<Rigidbody2D>();
                bi.velocity = new Vector2(speed, 0);
            }
            else
            {
                GameObject bulletInstance = Instantiate(rocket, transform.position, Quaternion.Euler(0, 0, 180));
                Rigidbody2D bi = bulletInstance.GetComponent<Rigidbody2D>();
                bi.velocity = new Vector2(-speed, 0);
                //Rigidbody2D bi = bulletInstance as Rigidbody2D;
            }
        }

    }
}
