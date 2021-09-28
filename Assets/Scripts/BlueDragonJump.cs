using UnityEngine;

public class BlueDragonJump : MonoBehaviour
{
    public Vector2 JumpForce;

    // Update is called once per frame
    void Update()
    {
        // when we hit the (Fire1 -> Left Mouse Button), our dragon will jump and the jump sound appears
        if(Input.GetButtonDown("Fire1"))
        {
            // jump
            GetComponent<Rigidbody2D>().AddForce(JumpForce);

            // play jump sound
            GetComponent<AudioSource>().Play();

        }
    }
}
