using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _playerPrefab;
    void Start()
    {
        PhotonNetwork.Instantiate(_playerPrefab.name, new Vector3(0, 0, 0), Quaternion.identity);
    }
    
}
