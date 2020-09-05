using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{
    public Transform pivot;
    public float spd = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(pivot.position, Vector3.forward, 20 * Time.deltaTime * spd);
        transform.rotation = Quaternion.Euler(Vector3.forward);
    }
}
