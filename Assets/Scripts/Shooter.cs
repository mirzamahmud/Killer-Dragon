using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectilePrefab;
    
    // Update is called once per frame
    void Update()
    {
        // when we hit left mouse button, BlueDragon will shoot the enemies
        if(Input.GetButtonDown("Fire1"))
        {
            // spawn our projectile
            var projectile = Instantiate(
                projectilePrefab, 
                transform.position, 
                projectilePrefab.transform.rotation);

            // fireball don't collide with blue-dragon
            Physics2D.IgnoreCollision(projectile.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }
}
