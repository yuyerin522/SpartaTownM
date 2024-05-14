using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{

    public event Action<Vector2> OnMoveEvent; // Action 은 무조건 void만 반환해야함 아니면 함수
    public event Action<Vector2> OnLookEvent; // Look 저거는 마우스

    public void CallMoveEvent(Vector2 direction)   // MoveEvent 말생했을때 Invoke하는 역할 - 디렉션 : 어느방향으로 움직여!
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);   //  ?. ==  없으면 말고 있으면 실행한다는 뜻
    }

}
