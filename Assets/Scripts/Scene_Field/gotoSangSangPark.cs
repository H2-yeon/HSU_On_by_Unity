﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
public class gotoSangSangPark : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Character;
    int cheak = 0;
    public Image im;
    private PhotonView PV;

    public float start = 0.0f;
    float finish = 2.1f;
    public bool fade = false;
    void Start()
    {
        
        if (Character = GameObject.Find("Boy(Clone)"))
        {
            PV = Character.GetPhotonView();
            if(PV.IsMine)
                cheak = 1;
        }
        else if (Character = GameObject.Find("Girl(Clone)"))
        {
            PV = Character.GetPhotonView();
            if (PV.IsMine)
                cheak = 1;
        }
        else if (Character = GameObject.Find("Boy2(Clone)"))
        {
            PV = Character.GetPhotonView();
            if (PV.IsMine)
                cheak = 1;
        }
        else if (Character = GameObject.Find("Girl2(Clone)"))
        {
            PV = Character.GetPhotonView();
            if (PV.IsMine)
                cheak = 1;

        }
        else if (Character = GameObject.Find("Boy3(Clone)"))
        {
            PV = Character.GetPhotonView();
            if (PV.IsMine)
                cheak = 1;
        }
        else if (Character = GameObject.Find("Girl3(Clone)"))
        {
            PV = Character.GetPhotonView();
            if (PV.IsMine)
                cheak = 1;
        }
        else if (Character = GameObject.Find("Boy4(Clone)"))
        {
            PV = Character.GetPhotonView();
            if (PV.IsMine)
                cheak = 1;
        }
        else if (Character = GameObject.Find("Girl4(Clone)"))
        {
            PV = Character.GetPhotonView();
            if (PV.IsMine)
                cheak = 1;
        }
        else if (Character = GameObject.Find("Boy5(Clone)"))
        {
            PV = Character.GetPhotonView();
            if (PV.IsMine)
                cheak = 1;
        }
        else if (Character = GameObject.Find("Girl5(Clone)"))
        {
            PV = Character.GetPhotonView();
            if (PV.IsMine)
                cheak = 1;
        }
        else if (Character = GameObject.Find("Bono(Clone)"))
        {
            PV = Character.GetPhotonView();
            if (PV.IsMine)
                cheak = 1;
        }
        else if (Character = GameObject.Find("Ghost(Clone)"))
        {
            PV = Character.GetPhotonView();
            if (PV.IsMine)
                cheak = 1;
        }
        else if (Character = GameObject.Find("Dora(Clone)"))
        {
            PV = Character.GetPhotonView();
            if (PV.IsMine)
                cheak = 1;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            fade = true;
            
                
            
        }
        
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        
    }
    private void Update()
    {

        if (fade == true)
        {
            if (start <= 1.0f)
            {
                im.color += new Color(0, 0, 0, Time.deltaTime);
            }
            else if (start > 1.0f && start < 1.1f) {
                Character.GetComponent<Transform>().position = new Vector3(-350, 1.75f, 71);
            }
            else if (start >= 1.1f && start <= finish)
            {
                im.color -= new Color(0, 0, 0, Time.deltaTime);
            }
            else if (start > finish)
            {
                start = 0.0f;
                fade = false;
            }
            start += Time.deltaTime;
        }
        
    }
}
