using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyCounter : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        //This is counting enemies on our cube. I make the door as a child of our cube for helping level designing.   
        if (collision.gameObject.tag == "Enemy")
        {
            GateController gateController = gameObject.GetComponentInChildren<GateController>();
            gateController.EnemyCountOnCube++;
            Debug.Log(gateController.EnemyCountOnCube.ToString());
        }
    }

    
}