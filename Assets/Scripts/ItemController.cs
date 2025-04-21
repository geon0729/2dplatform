using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    Vector2 pos; //현재위치

    float delta = 0.5f; // 좌(우)로 이동가능한 (y)최대값

    float Item_speed = 3f; // 이동속도

    private void Start()
    {
        pos = this.transform.position;
    }
    

    // Update is called once per frame
    void Update()
    {

        Vector3 v = pos;
        v.y += delta * Mathf.Sin(Time.time * Item_speed);
        transform.position = v;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }

}
