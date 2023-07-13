using UnityEngine;
using UnityEngine;

public class ArabaTakip : MonoBehaviour
{
    public Transform hedef; // Takip edilecek araban�n transform bile�eni
    public float mesafe = 10.0f; // Kameran�n arabadan uzakl���
    public float yukseklik = 5.0f; // Kameran�n arabadan y�ksekli�i
    public float yumusaklik = 5.0f; // Kamera takibindeki yumu�akl�k

    private Vector3 hedefPos;

    private void LateUpdate()
    {
        if (hedef == null)
            return;

        // Hedefin pozisyonunu, y�kseklik ve mesafe parametrelerine g�re ayarla
        hedefPos = hedef.position - hedef.forward * mesafe + Vector3.up * yukseklik;

        // Kameray� yumu�ak bir �ekilde hedefe do�ru takip et
        transform.position = Vector3.Lerp(transform.position, hedefPos, Time.deltaTime * yumusaklik);

        // Kameray� hedefin y�n�ne do�ru bakacak �ekilde d�nd�r
        transform.LookAt(hedef);
    }
}
