using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    [SerializeField] Transform ChildBullet;
    [SerializeField] int bulletSpeed;


    bool esquerda;

    private void Awake()
    {
        ChildBullet = transform.Find("New Sprite");       
    }

    void Start () {        
        if (PlayerController.esquerda == true)
        {
            ChildBullet.transform.eulerAngles = new Vector3(
                                                         ChildBullet.transform.eulerAngles.x,
                                                         ChildBullet.transform.eulerAngles.y + 180,
                                                         ChildBullet.transform.eulerAngles.z
                                                           );
            esquerda = true;
        }
    }

    // Update is called once per frame
    void Update()
    {       

        if (esquerda == true)
        {
            transform.Rotate(0, bulletSpeed * Time.deltaTime, 0);

        }
        else
        {
            transform.Rotate(0, -bulletSpeed * Time.deltaTime, 0);
        }

        Destroy(this.gameObject, 2);
    }
}
