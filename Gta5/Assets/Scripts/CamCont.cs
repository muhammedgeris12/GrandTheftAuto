using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CamCont : MonoBehaviour
{

    public Transform target;
    public Vector3 offset;
    [SerializeField]
    private float sensivity;
    float fareX, fareY;
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position,target.position+offset,Time.deltaTime*10);
        fareX += Input.GetAxis("Mouse X")*sensivity;
        fareY += Input.GetAxis("Mouse Y")*sensivity;
        if (fareY >= 25)
            fareY = 25;
        if (fareY <= -40)
            fareY = -40;
        this.transform.eulerAngles = new Vector3(fareY, fareX,0);
        target.transform.eulerAngles = new Vector3(0, fareX, 0);

    }
}
