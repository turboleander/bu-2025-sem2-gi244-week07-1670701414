using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10f;
    public GameObject playerGO;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerGO = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject playerGO = GameObject.Find("Player");
        bool isGameOver = playerGO.GetComponent<PlayerController>().isGameOver;
        if (isGameOver) { return; }
        transform.Translate(speed * Vector3.left * Time.deltaTime);
    }
}
