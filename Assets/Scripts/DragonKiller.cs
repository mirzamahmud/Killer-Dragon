using UnityEngine;
using UnityEngine.SceneManagement;

public class DragonKiller : MonoBehaviour
{
    int topJumpHeight = 6;
    float bottomJumpHeight = -5.6f;

    Scene scene;

    // Update is called once per frame
    void Update()
    {
        scene = SceneManager.GetActiveScene();

        // if our blue dragon jump too high, we kill it and load the scene.
        if(transform.position.y > topJumpHeight)
        {
            ScoreScript.scoreValues = 0;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
        // if our blue dragon jump too bottom, we kill it and load the scene.
        if(transform.position.y < bottomJumpHeight)
        {
            ScoreScript.scoreValues = 0;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    // here if the bluedragon collide with anything, we kill it and load the scene
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ScoreScript.scoreValues = 0;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
