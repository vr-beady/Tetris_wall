using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girl_trigger : MonoBehaviour
{
    private List<GameObject> colliders = new List<GameObject>();
    private string[] body = new string[13] { "head", 
        "Rshoulder", "Relbow", "Rhand",
        "Lshoulder", "Lelbow", "Lhand", 
        "Rpelvis", "Rknee", "Rfoot", 
        "Lpelvis", "Lknee", "Lfoot" };
    void Start()
    {
        /*GameObject head = GameObject.Find("mixamorig1:Head");
        Collider head_col = head.GetComponent<Collider>();

        GameObject Lshoulder = GameObject.Find("mixamorig1:LeftArm");
        Collider Lshoulder_col = Lshoulder.GetComponent<Collider>();*/
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!colliders.Contains(other.gameObject))
        {
            /*colliders.Add(other.gameObject);

            for (int i = 0; i < 13; i++) {
                if (other.gameObject.tag == body[i])
                {
                    Debug.Log(body[i] + "_touch");
                }
            }*/
            if (other.gameObject.tag == "head") {
                Debug.Log("head_touch");
            }
            if (other.gameObject.tag == "Rshoulder"){
                Debug.Log("Rshoulder_touch");
            }
            if (other.gameObject.tag == "Relbow"){
                Debug.Log("Relbow_touch");
            }
            if (other.gameObject.tag == "Rhand"){
                Debug.Log("Rhand_touch");
            }
            if (other.gameObject.tag == "Lshoulder"){
                Debug.Log("Lshoulder_touch");
            }
            if (other.gameObject.tag == "Lelbow"){
                Debug.Log("Lelbow_touch");
            }
            if (other.gameObject.tag == "Lhand"){
                Debug.Log("Lhand_touch");
            }
            if (other.gameObject.tag == "Rpelvis"){
                Debug.Log("Rpelvis_touch");
            }
            if (other.gameObject.tag == "Rknee"){
                Debug.Log("Rknee_touch");
            }
            if (other.gameObject.tag == "Rfoot"){
                Debug.Log("Rfoot_touch");
            }
            if (other.gameObject.tag == "Lpelvis"){
                Debug.Log("Lpelvis_touch");
            }
            if (other.gameObject.tag == "Lknee"){
                Debug.Log("Lknee_touch");
            }
            if (other.gameObject.tag == "Lfoot"){
                Debug.Log("Lfoot_touch");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        colliders.Remove(other.gameObject);
    }

}
