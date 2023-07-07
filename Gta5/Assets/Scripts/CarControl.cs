using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    public WheelCollider OnSolCol;
    public WheelCollider OnSagCol;
    public WheelCollider ArkaSolCol;
    public WheelCollider ArkaSagCol;

    public GameObject OnSol;
    public GameObject OnSag;
    public GameObject ArkaSol;
    public GameObject ArkaSag;

    public float maxMotorGucu;
    public float maxDonusAcýsý;
    public float motor;

 
    private void FixedUpdate()
    {
        motor = maxMotorGucu * Input.GetAxis("Vertical");
        float donus = maxDonusAcýsý * Input.GetAxis("Horizontal");

        OnSolCol.steerAngle = OnSagCol.steerAngle = donus;
        ArkaSagCol.motorTorque = motor;
        ArkaSolCol.motorTorque = motor;

        TekerDöndür();
    }
    void TekerDöndür()
    {
        Quaternion rot;
        Vector3 pos;
      
        OnSolCol.GetWorldPose(out pos, out rot);
        OnSol.transform.position = pos;
        OnSol.transform.rotation = rot; ;

        OnSagCol.GetWorldPose(out pos, out rot);
        OnSag.transform.position = pos;
        OnSag.transform.rotation = rot;

        ArkaSolCol.GetWorldPose(out pos, out rot);
        ArkaSol.transform.position = pos;
        ArkaSol.transform.rotation = rot;

        ArkaSagCol.GetWorldPose(out pos, out rot);
        ArkaSag.transform.position = pos;
        ArkaSag.transform.rotation = rot;
    }
}
