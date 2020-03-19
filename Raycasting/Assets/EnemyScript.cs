using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    public int health = 100;
	// Use this for initialization
	public void damage()
    {
        health -= 10;
        if(health < 0)
        {
            Destroy(this.gameObject);

        }
    }
}
