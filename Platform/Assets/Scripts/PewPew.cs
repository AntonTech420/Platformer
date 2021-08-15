using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PewPew : MonoBehaviour
{
    [SerializeField] Transform firePoint;
    [SerializeField] GameObject bullet;
    [SerializeField] float fireRate = 0.5f;
    [SerializeField] float cooldown = 0.5f;

    // Update is called once per frame
    void Update()
    {
        fireRate -= 1 * Time.deltaTime;
        if(Input.GetButtonDown("Fire1") && fireRate <= 0){
            Shoot();
            fireRate = cooldown;
        }
    }
    void Shoot(){
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}
