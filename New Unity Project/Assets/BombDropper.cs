using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDropper : MonoBehaviour
{
    [Header("Set in Inspector")]
    //Instantiate the player
    public GameObject playerPrefab;
  
  

    void Start()
    {
        
            GameObject player= Instantiate<GameObject>(playerPrefab);
        Vector3 pos = Vector3.zero;
        player.transform.position = pos;
          
       
    }
}
