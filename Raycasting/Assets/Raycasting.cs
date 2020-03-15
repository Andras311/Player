using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Raycasting : MonoBehaviour {
   
    public Camera cam;
    public ParticleSystem ps;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            ps.Play();
            
            RaycastHit hit;
            Vector3 rayOrigin = cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
            if (Physics.Raycast(rayOrigin, cam.transform.forward, out hit, Mathf.Infinity))
            {
                if (hit.collider.tag == "Enemy")
                {
                    Destroy(hit.collider.gameObject);
                   
                }
            }
                
                
        }
            
            
        
        
    }
}
