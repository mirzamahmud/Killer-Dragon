using UnityEngine;

public class EnemyMoveUpDown : MonoBehaviour
{
    private float heightVarience = 1f;

    // Update is called once per frame
    void Update()
    {
        // enemy moves like Sin wave
        transform.position += Vector3.up * Mathf.Sin(Time.time) * Time.deltaTime * heightVarience;
    }
}
