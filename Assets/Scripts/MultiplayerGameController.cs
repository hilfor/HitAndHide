using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MultiplayerGameController : Photon.PunBehaviour
{

    public GameObject standbyCamera;

    public GameObject[] availableSpawnPoints;

    public string gameVersion;

    public Text photonConnectionState;

    public GameObject localPlayerPrefab;

    [Range(0.0f, 1.0f)]
    public float redBlueRatio;

    private PlayerSpawnPoint[] spawnPoints;

    void Start()
    {
        spawnPoints = new PlayerSpawnPoint[availableSpawnPoints.Length];
        for (int spawnPointIndex = 0; spawnPointIndex < availableSpawnPoints.Length; spawnPointIndex++)
        {
            spawnPoints[spawnPointIndex] = availableSpawnPoints[spawnPointIndex].GetComponent<PlayerSpawnPoint>();
        }
        PhotonNetwork.offlineMode = true;
        PhotonNetwork.autoJoinLobby = true;

        PhotonNetwork.ConnectUsingSettings("0.1");
    }

    void OnGUI()
    {
        photonConnectionState.text = PhotonNetwork.connectionStateDetailed.ToString();
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        if (PhotonNetwork.offlineMode)
        {
            OnJoinedLobby();
        }
        else
        {

            PhotonNetwork.JoinLobby();
        }
    }

    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();
        Debug.Log("Joined a lobby");
        RoomOptions roomOptions = new RoomOptions();

        PhotonNetwork.JoinOrCreateRoom("test", roomOptions, TypedLobby.Default);

    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        Debug.Log("Joined room");
        SpawnPlayer();
    }

    private void SpawnPlayer()
    {
        float randomside = Random.value;
        PlayerSide playerSide;

        if (randomside < redBlueRatio)
        {
            playerSide = PlayerSide.RED;
        }
        else
        {
            playerSide = PlayerSide.BLUE;
        }
        Debug.Log("The players side is " + playerSide);

        Vector3 spawnLocation = getSpawnlocation(playerSide);
        GameObject player = PhotonNetwork.Instantiate(localPlayerPrefab.name, spawnLocation, Quaternion.identity, 0);

        player.GetComponent<PlayerMonitor>().SetPlayerSide(playerSide);
        standbyCamera.SetActive(false);
    }

    Vector3 getSpawnlocation(PlayerSide playerSide)
    {
        ArrayList playersSideSpawnPoints = new ArrayList();
        foreach (PlayerSpawnPoint spawnPoint in spawnPoints)
        {
            if (spawnPoint.spawnSide == playerSide)
            {
                playersSideSpawnPoints.Add(spawnPoint);
            }
        }
        int randomSpawnIndex = Mathf.FloorToInt(Random.Range(0f, playersSideSpawnPoints.Count- 1));
        return ((PlayerSpawnPoint)playersSideSpawnPoints[randomSpawnIndex]).transform.position;
    }

    void Update() { }

}
