using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawAttack : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target) {
        
        if(target.tag == "Player") {
            target.SendMessage("Panic", gameObject);
        }
    }
}