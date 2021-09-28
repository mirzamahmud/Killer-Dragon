using UnityEngine;

public class StumpsMoveLeft : MonoBehaviour
{
    public float enemySpeed = 1;

    private Enemy enemy;

    public void Awake()
    {
        enemy = GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * enemySpeed, Space.World);

        // reuse stump
        if (transform.position.x < -12)
        {
            transform.position += new Vector3(22, 0, 0);

            // randomly select stumps
            ShowRandomEnemy();

            // respawn enemy if it exists
            enemy?.Respawn();
        }
    }

    private void ShowRandomEnemy()
    {
        int stumpIndex = UnityEngine.Random.Range(0, 4);
        int stumpCount = transform.childCount;
        int i;

        for (i = 0; i < stumpCount; i++)
        {
            Transform stumpChild = transform.GetChild(i);

            bool shouldShowStumps = (stumpIndex == i);
            stumpChild.gameObject.SetActive(shouldShowStumps);
        }
    }

    // pick up random stumps from starting the game
    private void OnEnable()
    {
        ShowRandomEnemy();
    }

}