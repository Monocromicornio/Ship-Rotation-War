using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    [SerializeField] GameObject bullet;
    [SerializeField] GameObject player;

    bool esquerda;

    void Start () {
        player = GameObject.Find("Player_Nave");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _shoot();
        }
        if (PlayerController.esquerda == true)
        {           
            esquerda = true;
        }
        else
        {
            esquerda = false;
        }
    }


    void _shoot()
    {

        if (esquerda)
        {
            Instantiate(bullet, new Vector3(0, player.transform.position.y, 0), Quaternion.Euler(0, transform.eulerAngles.y + 6, 0));
        }
        else
        {
            Instantiate(bullet, new Vector3(0, player.transform.position.y, 0), Quaternion.Euler(0, transform.eulerAngles.y, 0));
        }
    
      
    }

}
