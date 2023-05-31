using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girl_trigger : MonoBehaviour
{
    private List<GameObject> colliders = new List<GameObject>();
    private GameManager gameManager;

    private string[] body = new string[13] { "Head", 
        "Rshoulder", "Relbow", "Rhand",
        "Lshoulder", "Lelbow", "Lhand", 
        "Rpelvis", "RKnee", "Rfoot", 
        "Lpelvis", "Lknee", "Lfoot" };


    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.UpdateScore(0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!colliders.Contains(other.gameObject))
        {
            colliders.Add(other.gameObject);
            
            for (int i = 0; i < 13; i++) {
                if (other.gameObject.tag == body[i])
                {
                    gameManager.UpdateScore(1);
                    Debug.Log(body[i] + "_touch" );
                }
            }

        }
    }
    void Update()
    {

    }

    private void OnTriggerExit(Collider other)
    {
        colliders.Remove(other.gameObject);
        gameManager.score = 0;
    }
}
