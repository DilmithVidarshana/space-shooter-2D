using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectMissile : MonoBehaviour
{
     private void OnTriggerEnter2D (Collider2D target)
    {
        if(target.tag == "Missile")
        {
          
           target.gameObject.SetActive(false);
        }
    }
}
