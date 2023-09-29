using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordController : MonoBehaviour
{
    [SerializeField]
    GameObject bulletPrefab;

    [SerializeField]
    Transform swordEndPosition;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void PullTrigger()
    {
        Instantiate(bulletPrefab, swordEndPosition.position, swordEndPosition.rotation);
    }
}
