using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    Scene scene;

    public void NextLevel()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //ScoreScript.scoreValues = 0;

        scene = SceneManager.GetActiveScene();

        if(scene.name == "Scene-1-Complete")
        {
            SceneManager.LoadScene("Scene-2");
            ScoreScript.scoreValues = 0;
        }

        if (scene.name == "Scene-2-Complete")
        {
            SceneManager.LoadScene("EndGame");
           
        }
    }

}
