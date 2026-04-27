using System;
using UnityEngine;

public class Finish : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.name == "Player")
        {
            Debug.Log("Game Finished");
        }
    }
}
