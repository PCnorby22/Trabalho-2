using UnityEngine;

public class rotaçao : MonoBehaviour
{
    Rigidbody rb;
    public GameObject move;
    public float torque;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.LookAt(move.transform.position);
        if (Input.GetKey(KeyCode.D)){
            rb.AddTorque(transform.up * torque);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(transform.up * torque * -1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddTorque(Vector3.forward * torque);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddTorque(Vector3.forward * torque * -1);
        }
    }
}
