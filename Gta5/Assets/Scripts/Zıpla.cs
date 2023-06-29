using UnityEngine;

public class Zýpla : MonoBehaviour
{
    public float ziplamaGucu = 5f;
    private bool ziplamaYetkisi = true;

    private Rigidbody rb;

    Animator anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (ziplamaYetkisi && Input.GetKeyDown(KeyCode.Space))
        {
            Zipla();
           // anim.SetBool("IsJumping", true);

        }

    }

    private void Zipla()
    {
        rb.AddForce(Vector3.up * ziplamaGucu, ForceMode.Impulse);
        ziplamaYetkisi = false;

        anim.SetBool("IsJumping", true);


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Zemin"))
        {
            ziplamaYetkisi = true;
            anim.SetBool("IsJumping", false);
        }
    }
}
