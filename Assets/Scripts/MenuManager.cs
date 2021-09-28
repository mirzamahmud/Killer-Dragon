using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public GameObject Panel, Panel1;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Settings()
    {
        Panel.GetComponent<Animator>().SetTrigger("Pop");
    }

    public void Others()
    {
        Panel1.GetComponent<Animator>().SetTrigger("Pop");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Scene-1");
    }

}
