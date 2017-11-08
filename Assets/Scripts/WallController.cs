using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour {

    public GameObject wall;

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.tag);
        if (other.CompareTag("Player"))
        {
            wall.gameObject.SetActive(true);
        }
    }
}
