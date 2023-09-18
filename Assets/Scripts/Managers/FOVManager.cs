using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FOVManager : MonoBehaviour
{
    [Header("*** FOV ***")]
    [Space]

    [SerializeField] public float fov;


    private void OnDrawGizmos()
    {
        Handles.color = new Color(0,1,0,0.3f);
        Handles.DrawSolidDisc(transform.position,transform.up, fov);    
    }

    

   
}