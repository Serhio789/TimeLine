using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Delet_Object : MonoBehaviour
{
    public Rigidbody body;
    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }
    public void WantToDestroy()
    {
        Destroy(gameObject);
    }
    public void WantToScale()
    {
        transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
    }
    public void WantToImpulse()
    {
        body.AddForce(Vector3.back, ForceMode.Impulse);
    }
}
