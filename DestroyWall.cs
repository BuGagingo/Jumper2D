using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWall : MonoBehaviour
{
    public GameObject lastPlatform;
    public List<GameObject> specialsPlatform;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
        
        if (collision.gameObject.CompareTag("Platform"))
        {
            float posY= lastPlatform.transform.position.y; 
            collision.gameObject.transform.position = new Vector2( Random.Range(-8, 8),Random.Range(posY + 3f, posY + 4.5f));
            lastPlatform = collision.gameObject;
        }

        var r = Random.Range(0, 100);
        if (r <= 30)
        {
            float posY= lastPlatform.transform.position.y;
            GameObject newPlatform = Instantiate(specialsPlatform[Random.Range(0, specialsPlatform.Count)], 
                new Vector3(Random.Range(-7.5f, 7.5f), Random.Range(posY + 3f, posY + 4.5f), 0),
                Quaternion.identity);
            lastPlatform = newPlatform;
        }
    }
}
