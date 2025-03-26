using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Vector2 controllerInput;
    public float speed = 1f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        controllerInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        //Vector3 movementConrtoller = new Vector3(controllerInput.x, 0, controllerInput.y);
        //transform.Translate(controllerInput * Time.deltaTime*speed);

    }
    private void FixedUpdate()
    {
        //wyliczmy docelowa pozycje gracza _po_ ruchu
        //najpierw liczyny wektor przesuniecia
        Vector3 movementConrtoller = new Vector3(controllerInput.x, 0, controllerInput.y) ;
        //dodajemy go do obecnego polozenia gracza tworzac pozycje docelowa
        Vector3 targetPosition = transform.position + movementConrtoller * Time.fixedDeltaTime * speed;
        //przesuwamy gracza przy uzyciu MovePosition
        rb.MovePosition(targetPosition);
    }

}
