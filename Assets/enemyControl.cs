using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyControl : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    public float speed = 3f;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);    
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
    private void FixedUpdate()
    {
        

    }
}
