using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    Animator anim;
    public float karekterHiz;

    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    void Update()
    {
        Hareket();
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("Punch", true);
        }
        else
        {
            anim.SetBool("Punch", false);
        }
        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W)) 
        {
            karekterHiz = 10;
            anim.SetBool("IsRuning", true);
            anim.SetBool("LeftRun", false);
            anim.SetBool("RightRun", false);
        }
        else if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.D))
        {
            karekterHiz = 10;
            anim.SetBool("RightRun", true);
            anim.SetBool("LeftRun", false);
        }
        else if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.A))
        {
            karekterHiz = 10;
            anim.SetBool("LeftRun", true);
            anim.SetBool("RightRun", false);

        }
        else
        {
            karekterHiz = 5;
            anim.SetBool("IsRuning", false);
            anim.SetBool("RightRun", false);
            anim.SetBool("LeftRun", false);
        }
    }
    void Hareket()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        anim.SetFloat("Horizontal",yatay);
        anim.SetFloat("Vertical", dikey);
        this.gameObject.transform.Translate(yatay * karekterHiz*Time.deltaTime, 0, dikey * karekterHiz*Time.deltaTime);
    }

}
