using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10f;
    //public GameObject playerGO;
    //public PlayerController player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject playerGO = GameObject.Find("Player");
        PlayerController player = playerGO.GetComponent<PlayerController>();
        if (player.isGameOver == true) { return; }
        transform.Translate(speed * Vector3.left * Time.deltaTime);
    }
}
