﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    private string gameVersion = "1";

    public Text connectionInfoText;

    public Button joinButton;

  
    private void Start()
    {
        PhotonNetwork.GameVersion = gameVersion;

        PhotonNetwork.ConnectUsingSettings();

        joinButton.interactable = false;
        joinButton.onClick.AddListener(Connect);

        connectionInfoText.text = "서버에 접속중..";

    }

    //마스터 서버 접속 성공시
    public override void OnConnectedToMaster()
	{
        joinButton.interactable = true;

        connectionInfoText.text = "온라인 : 마스터 서버와 연결완료";
	}
    
    //마스터 서버 접속 실패시
    public override void OnDisconnected(DisconnectCause cause)
	{
        // 룸 접속 버튼을 비활성화
        joinButton.interactable = false;
       
        //접속 정보 표시
        connectionInfoText.text = "오프라인 : 마스터 서버와 연결되지 않음\n 접속 재시도중...";
        //마스터 서버로의 재접속 시도
        PhotonNetwork.ConnectUsingSettings();
	}

    //룸 접속 시도
    public void Connect()
	{
        joinButton.interactable = false;

        if(PhotonNetwork.IsConnected)
		{
            //룸 접속 실행
            connectionInfoText.text = "룸에 접속..";
            PhotonNetwork.JoinRandomRoom();
		}
		else
		{
            connectionInfoText.text = "오프라인 : 마스터 서버와 연결되지 않음\n 접속 재시도중...";
            //마스터 서버로의 재접속 시도
            PhotonNetwork.ConnectUsingSettings();
        }
	}

    public override void OnJoinRandomFailed(short returnCode, string message)
	{
        connectionInfoText.text = "빈 방이 없음, 새로운 방 생성";


        PhotonNetwork.CreateRoom(null, new RoomOptions { MaxPlayers = 4 });

	}
    
    public override void OnJoinedRoom()
	{
        //접속 상태 표시
        connectionInfoText.text = "방 참가 성공";
        //모든 룸 참가자들이 Main 씬을 로드하게 한다.
        PhotonNetwork.LoadLevel("Scene_Field");


	}
    
        
    
}
