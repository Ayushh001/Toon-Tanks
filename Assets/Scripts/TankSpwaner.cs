using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpwaner : MonoBehaviour
{
    public GameObject tankprefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(tankprefab, transform.position, Quaternion.identity);
    }
}