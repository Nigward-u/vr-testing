using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bullet; 
    public Transform shoot_point;
    
    
    
        public void Shoot()
        {
            Instantiate(bullet,shoot_point.position,Quaternion.identity);
        }
        
    
}
