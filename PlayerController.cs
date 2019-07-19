using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] int speed;
    [SerializeField] int cimaBaixoSpeed;
    [SerializeField] GameObject player;

    public static bool direita = true;
    public static bool esquerda;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player_Nave");
	}

    // Update is called once per frame
    void Update()
    {
        //Mover
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direita = true;
            transform.Rotate(new Vector3(0, -speed, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            esquerda = true;
            transform.Rotate(new Vector3(0, speed, 0) * Time.deltaTime);
        }

        //Rodar Player
        if (Input.GetKeyDown(KeyCode.RightArrow) && esquerda == true)
        {
            player.transform.eulerAngles = new Vector3(
                                                         player.transform.eulerAngles.x,
                                                         player.transform.eulerAngles.y + 180,
                                                         player.transform.eulerAngles.z
                                                      );
            esquerda = false;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && direita == true)
        {
            player.transform.eulerAngles = new Vector3(
                                                         player.transform.eulerAngles.x,
                                                         player.transform.eulerAngles.y + 180,
                                                         player.transform.eulerAngles.z
                                                      );
            direita = false;
        }


        //Cima e baixo
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, cimaBaixoSpeed, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -cimaBaixoSpeed, 0) * Time.deltaTime);
        }

    }

    void Rodar()
    {
       
    }

}
