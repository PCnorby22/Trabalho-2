using UnityEngine;

public class ray : MonoBehaviour
{
    public float rayDistance = 10f; // Dist�ncia do Raycast
    public LayerMask layerMask;     // (Opcional) Define em quais layers o Raycast pode acertar

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ray ray = new Ray(transform.position, transform.right);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, rayDistance, layerMask))
            {
                // Destroi o objeto atingido
                Destroy(hit.collider.gameObject);
                Debug.Log("Objeto destru�do: " + hit.collider.gameObject.name);
            }
        }
    }
}
