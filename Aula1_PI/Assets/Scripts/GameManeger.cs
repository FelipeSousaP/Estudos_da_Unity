using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    public Queue<GameObject> Fila;
    static GameManeger Singloton;
    private GameObject BalaSalvas;
    // Os dois devem ser estaticos
    private void Awake()
    {
        Fila = new Queue<GameObject>();
        if(Singloton == null)
        {
            Singloton = this;
        }
    }
    public static GameManeger Instance
    {
        get
        {
            return Singloton;
        }
    }

    public void SetQueue(GameObject _balas)
    {
        BalaSalvas = _balas;
        Fila.Enqueue(BalaSalvas);
    }

    public GameObject GetBullet()
    {
        Fila.Dequeue(); // remover da fila
        return BalaSalvas; //returnar bala
    }
}
