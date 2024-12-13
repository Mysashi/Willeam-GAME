using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public static Player Instance;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this; // ”становите единственный экземпл€р
            DontDestroyOnLoad(gameObject); // —делайте объект посто€нным
        }
        else
        {
            Destroy(gameObject); // ”ничтожьте дубликаты
        }
    }
}
