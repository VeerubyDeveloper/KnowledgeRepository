using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingTargets : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }
    }
}
