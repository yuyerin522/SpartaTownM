using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private float speed;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        // 매프레임마다 Vertical 축과 Horizontal 축을 가져옵니다
        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");

        Vector2 direction = new Vector2(horizontal, vertical);  
        // 0,0 0,1 1,1 일 수도 있기 때문에 정규화를 해준다
        // 정규화 - 길이를 1로 만드는 작업
        direction = direction.normalized;

        rb.velocity = direction * speed;

    }
}
