using UnityEngine;

public class movecamera : MonoBehaviour
{
    GameObject move;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        move = GameObject.Find("move");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(move.transform.position.x, this.transform.position.y, this.transform.position.z);
    }
}
