using UnityEngine;
using UnityEngine.SceneManagement;

public class Fireball : MonoBehaviour
{
    public Vector2 StartingVelocity;
    Scene scene;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = StartingVelocity;
        Destroy(gameObject, 3);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        scene = SceneManager.GetActiveScene();

        ScoreScript.scoreValues += 5;

        if(scene.name == "Scene-1" && ScoreScript.scoreValues == 100)
        {
            SceneManager.LoadScene("Scene-1-Complete");
        }

        if(scene.name == "Scene-2" && ScoreScript.scoreValues == 200)
        {
            SceneManager.LoadScene("Scene-2-Complete");
        }

        // if fireball hit the enemy, it will die
        var enemy = collision.collider.GetComponent<Enemy>();

        enemy?.Die(); // that means, it check to see if the (enemy) exists and only (Die()) is exists will call Die()

        Destroy(gameObject);
    }
}
