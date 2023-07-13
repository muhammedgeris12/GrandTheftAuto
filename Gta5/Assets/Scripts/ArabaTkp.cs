using UnityEngine;
using UnityEngine;

public class ArabaTakip : MonoBehaviour
{
    public Transform hedef; // Takip edilecek arabanýn transform bileþeni
    public float mesafe = 10.0f; // Kameranýn arabadan uzaklýðý
    public float yukseklik = 5.0f; // Kameranýn arabadan yüksekliði
    public float yumusaklik = 5.0f; // Kamera takibindeki yumuþaklýk

    private Vector3 hedefPos;

    private void LateUpdate()
    {
        if (hedef == null)
            return;

        // Hedefin pozisyonunu, yükseklik ve mesafe parametrelerine göre ayarla
        hedefPos = hedef.position - hedef.forward * mesafe + Vector3.up * yukseklik;

        // Kamerayý yumuþak bir þekilde hedefe doðru takip et
        transform.position = Vector3.Lerp(transform.position, hedefPos, Time.deltaTime * yumusaklik);

        // Kamerayý hedefin yönüne doðru bakacak þekilde döndür
        transform.LookAt(hedef);
    }
}
