using UnityEngine;

public class TreeLeaves : MonoBehaviour
{
    public GameObject leafPrefab;

    public Sprite[] leafSprites;

    public Transform spawnPoint;

    public int leafCount = 8;

    private void OnMouseDown()
    {
        SpawnLeaves();
    }

    void SpawnLeaves()
    {
        for (int i = 0; i < leafCount; i++)
        {
            Vector3 pos = spawnPoint.position;

            pos.x += Random.Range(-3f, 3f);
            pos.y += Random.Range(-1f, 1f);

            GameObject leaf = Instantiate(leafPrefab, pos, Quaternion.identity);

            SpriteRenderer sr = leaf.GetComponent<SpriteRenderer>();

            sr.sprite = leafSprites[Random.Range(0, leafSprites.Length)];
        }
    }
}