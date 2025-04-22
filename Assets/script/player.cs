using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public GameObject reiniciar, vitoria;
    public Slider distancia;
    Rigidbody rb;
    Vector3 inicio;
    public int velocidade;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        inicio = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector3(1 * velocidade * Time.fixedDeltaTime, rb.linearVelocity.y, rb.linearVelocity.z);
        Vector3 dis = this.transform.position - inicio;
        distancia.value = ((int)dis.magnitude);
        if (dis.magnitude >= 500f)
        {
            vitoria.SetActive(true);
            reiniciar.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
