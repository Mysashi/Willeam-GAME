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
            DontDestroyOnLoad(gameObject); // Запретить уничтожение при смене сцен
        }
        else
        {
            Destroy(gameObject); // Уничтожить дубликаты
        }
    }
}
