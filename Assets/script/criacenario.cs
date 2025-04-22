using UnityEngine;

public class criacenario : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject[] cenario;
    public GameObject chao;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        int x = Random.Range(0, 3);
        Instantiate(cenario[x], new Vector3(chao.transform.position.x+36, chao.transform.position.y, chao.transform.position.z), this.transform.rotation);
        Destroy(this.gameObject);
    }
}
