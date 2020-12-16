using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteractTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //When player enters NPC box collider
    void OnTriggerEnter2D(Collider2D other)
    {
        //Checks if gameObject has player tag
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hello Player");
        }
        else
        {
            Debug.Log("What");
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
