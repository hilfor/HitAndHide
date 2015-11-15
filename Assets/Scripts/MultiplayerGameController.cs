using UnityEngine;
using System.Collections;

public class MultiplayerGameController : MonoBehaviour {

	public GameObject standbyCamera;

	public GameObject[] availableSpawnPoints;

	private PlayerSpawnPoint[] spawnPoints;


	void Start(){
		spawnPoints = new PlayerSpawnPoint[availableSpawnPoints.Length];
		for (int spawnPointIndex = 0 ; spawnPointIndex< availableSpawnPoints.Length; spawnPointIndex++){
			spawnPoints[spawnPointIndex] = availableSpawnPoints[spawnPointIndex].GetComponent<PlayerSpawnPoint>();
		}
	}

	void Update(){}
		
}
