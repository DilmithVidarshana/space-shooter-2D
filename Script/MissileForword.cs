using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissileForword : MonoBehaviour
{
    private float maxSpedd = 5f;


    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, maxSpedd* Time.deltaTime,0);
        pos += transform.rotation * velocity;

        transform.position = pos;
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
       if(target.tag == "Enamy")
       {
        Destroy(target.gameObject);
       }
    }
   
}
