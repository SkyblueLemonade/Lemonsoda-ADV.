using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;

    public float bulletSpeed = 10f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * bulletSpeed;
    }
}
