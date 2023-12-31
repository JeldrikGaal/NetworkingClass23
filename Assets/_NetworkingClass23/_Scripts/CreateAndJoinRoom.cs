using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class CreateAndJoinRoom : MonoBehaviourPunCallbacks
{
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        RoomOptions roomOptions = new RoomOptions { MaxPlayers = 2, IsOpen = true, IsVisible = true };
        PhotonNetwork.JoinOrCreateRoom("Room", roomOptions, TypedLobby.Default);
    }
    
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }

}
