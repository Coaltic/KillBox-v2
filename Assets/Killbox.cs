using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killbox : MonoBehaviour
{
    public Player playerScript;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        

        if (other.tag == "Player")
        {
            playerScript.respawnLocation = playerScript.currentCheckpoint - other.transform.position;
            Debug.Log("triggered");
            other.GetComponent<CharacterController>().Move(playerScript.respawnLocation);
        }
    }
}
