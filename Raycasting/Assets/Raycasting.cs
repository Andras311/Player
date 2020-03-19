using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Raycasting : MonoBehaviour {
   
    public Camera cam;
    public ParticleSystem ps;
    private float timer = 0f;
    public int bullets = 10;
    private EnemyScript EnemyController;
    
    
	// Use this for initialization
	void Start () {
        timer = 2;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0) && timer > 0.25)
        {
            ps.Play();
            timer = 0;
            bullets--;
            RaycastHit hit;
            Vector3 rayOrigin = cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
            if (Physics.Raycast(rayOrigin, cam.transform.forward, out hit, Mathf.Infinity))
            {
                if (hit.collider.tag == "Enemy")
                {
                    EnemyController = hit.collider.gameObject.GetComponent<EnemyScript>();
                    EnemyController.damage();
                    
                   
                }
            }
            if(bullets == 0)
            {
                //újratöltés animáció
                Debug.Log("reloading");
                bullets = 10;
            }
                
                
        }
        timer += Time.deltaTime;
       




    }
}
