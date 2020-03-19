using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPController : MonoBehaviour {
    public Transform Hp;
    private float health = 300;
    public float damage = 100f;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("k"))
        {
            health -= damage;
            Hp.gameObject.transform.localScale = new Vector3(health, 1, 1);
            Hp.gameObject.transform.position -= Vector3.right * (damage / 2);
        }
	}
}
