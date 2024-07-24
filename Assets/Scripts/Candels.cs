using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candels : MonoBehaviour
{
    [SerializeField] private GameObject fayer;
    public void Spark_Plugs()
    {
        fayer.SetActive(true);
    }
}
