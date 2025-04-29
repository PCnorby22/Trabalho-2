using UnityEngine;
using UnityEngine.UI;

public class ray : MonoBehaviour
{
    public float rayDistance = 10f;
    public LayerMask layerMask;
    public Slider poder;
    float t = 0;
    private void Start()
    {
        poder.value = 0;
    }
    void Update()
    {
        t += Time.fixedDeltaTime;
        if (t >= 10 && poder.value <=poder.maxValue)
        {
            poder.value++;
            t = 0;
        }
        if (Input.GetKey(KeyCode.Space) && poder.value >= poder.maxValue)
        {
            poder.value = 0;
            Ray ray = new Ray(transform.position, transform.right);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "obistaculo")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
