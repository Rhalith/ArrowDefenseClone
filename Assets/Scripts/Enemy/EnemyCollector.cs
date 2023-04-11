using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollector : MonoBehaviour
{
    private int playerNumber;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
            playerNumber++;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        playerNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
