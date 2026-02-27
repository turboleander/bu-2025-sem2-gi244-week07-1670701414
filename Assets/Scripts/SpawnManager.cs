using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject obstaclePrefab;
    public PlayerController player;

    void Start()
    {
        InvokeRepeating(nameof(Spawn), 0f, 2f);
    }

    void Spawn()
    {
        if (player.isGameOver == true) { return; }

        //GameObject playerGO = GameObject.Find("Player");
        //PlayerController player = playerGO.GetComponent<PlayerController>();
        //if (player.isGameOver == true) { return; }

        Instantiate(
            obstaclePrefab,
            spawnPoint.position,
            obstaclePrefab.transform.rotation
        );
    }
}
