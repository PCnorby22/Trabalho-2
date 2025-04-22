using TMPro;
using UnityEngine;

public class controleplayer : MonoBehaviour
{
    public GameObject reiniciar, derrota;
    public TextMeshProUGUI vidaTela;
    public int vida;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vidaTela.text = vida.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        vidaTela.text = vida.ToString();
        if (vida <= 0)
        {
            derrota.SetActive(true);
            reiniciar.SetActive(true);
            Time.timeScale = 0;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obistaculo")
        {
            vida--;
        }
    }
}
