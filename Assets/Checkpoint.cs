using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
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
            playerScript.currentCheckpoint = other.transform.position;
            this.gameObject.SetActive(false);
;        }
    }
}
