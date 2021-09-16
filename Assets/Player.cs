using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 respawnLocation;
    public Vector3 startPosition;
    public Vector3 currentCheckpoint;

    public int enemiesKilled;
    public GameObject enemyCheckpoint;

    void Start()
    {
        startPosition = transform.position;
        currentCheckpoint = startPosition;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("e"))
        {
            enemiesKilled = enemiesKilled + 1;

            if (enemiesKilled == 3)
            {
                enemyCheckpoint.gameObject.SetActive(true);
                currentCheckpoint = enemyCheckpoint.transform.position;
                enemyCheckpoint.gameObject.SetActive(false);
                enemiesKilled = 4;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
      
    }
}
