using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////
    public float maxSpeed = 0.1f;
    public float rotation = 0.0f;
    public float camRotation = 0.0f;
    public GameObject cam;
    Rigidbody myRigidbody;

    public float rotationSpeed = 2.0f;
    public float camRotationSpeed = 1.5f;
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////
    bool isOnGround;
    public GameObject groundChecker;
    public LayerMask groundLayer;
    public float jumpForce = 300.0f;
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////
    void Start()
    {
        cam = GameObject.Find("Main Camera");
    }

    void Update()
    {
        ////////////////////////Ground Checker//////////////////////////////////////////////////////////////
        isOnGround = Physics.CheckSphere(groundChecker.transform.position, 0.1f, groundLayer);

        if (isOnGround == true && Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody.AddForce(transform.up * jumpForce);
        }




        ////////////////////Camera Control/////////////////////////////////////////////////////////////

        

        rotation = rotation + Input.GetAxis("Mouse X") * rotationSpeed;
        transform.rotation = Quaternion.Euler(new Vector3(0.0f, rotation, 0.0f));



        camRotation = camRotation + Input.GetAxis("Mouse Y") * camRotationSpeed;
        cam.transform.localRotation = Quaternion.Euler(new Vector3(camRotation, 0.0f, 0.0f));

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////
    }


}