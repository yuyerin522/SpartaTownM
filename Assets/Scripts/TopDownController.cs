using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{

    public event Action<Vector2> OnMoveEvent; // Action �� ������ void�� ��ȯ�ؾ��� �ƴϸ� �Լ�
    public event Action<Vector2> OnLookEvent; // Look ���Ŵ� ���콺

    public void CallMoveEvent(Vector2 direction)   // MoveEvent ���������� Invoke�ϴ� ���� - �𷺼� : ����������� ������!
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);   //  ?. ==  ������ ���� ������ �����Ѵٴ� ��
    }

}
