using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public static PlayerCamera Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // ��������� ����������� ��� ����� ����
        }
        else
        {
            Destroy(gameObject); // ���������� ���������
        }
    }
}
