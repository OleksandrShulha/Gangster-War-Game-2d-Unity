using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoopAtackDef : MonoBehaviour
{
    [SerializeField] GameObject fireBomd, gun;

    public void Fire()
        {
        Instantiate(fireBomd, gun.transform.position, transform.rotation);
        }
}
