﻿using Photon.Pun;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventInstance : MonoBehaviour
{
    public GameObject winnerPanel;
    public Text winnerBanner;

    public GameObject ScorePanel;
    public Text ScoreBoard;
    public Text TimeBoard;
    public float timer = 120f;

    public GameObject chatBox;
    public GameObject chatBtn_off;
    public GameObject chatBtn_on;

    public Clock Clock;
    private Hashtable hashtable = new Hashtable();
    private bool isEventStart= false;

    PhotonView PV;

    [PunRPC]
    private void addRanker(string msg, int score) {
        if (hashtable.ContainsKey(msg))
        {
            hashtable[msg] = (int)hashtable[msg] + score;
        }
        else 
        {
            hashtable.Add(msg,score);
        }
    }

    public void hitchicken(string playerName, int score) {
        PV.RPC("addRanker", RpcTarget.AllBuffered, playerName, score);
    }

    private void EventStart() {
        chatBox.SetActive(false);
        chatBtn_off.SetActive(false);
        chatBtn_on.SetActive(true);

        ScorePanel.SetActive(true);
        isEventStart = true;
        
    }

    private void EventEnd() {
        ScorePanel.SetActive(false);
        isEventStart = false;

        string winner="";
        int winnerScore=0;
        foreach (DictionaryEntry d in hashtable) {
            if (winnerScore < (int)d.Value) {
                winnerScore = (int)d.Value;
                winner = d.Key.ToString();
            }
        }
        winnerPanel.SetActive(true);
        winnerBanner.text = string.Format("우승! {0} {1}점", winner,  winnerScore);

    }
    private string HashToString(Hashtable hashtable) {
        string result="";

        foreach (DictionaryEntry d in hashtable) {
            result += string.Format("{0} : {1}점\n", d.Key, d.Value);
        }

        return result;
    } 

    void Start()
    {
        PV = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
         
        if (Clock.clock.text.Equals("14:00")) {
            EventStart();
        }

        if (isEventStart) {
            TimeBoard.text = (timer - Time.deltaTime).ToString();
            ScoreBoard.text = HashToString(hashtable);
            if (timer < 0)
                EventEnd();
        }
    }
}