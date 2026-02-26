using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    public Queue<GameObject> Fila = new Queue<GameObject>();
    static GameManeger Singloton;
    // Os dois devem ser estaticos
    #region Singloton
    public static GameManeger Instance
    {
        get { return Singloton; }
    }
    private void Awake()
    {
        //Qunado o jogo começar
        Fila = new Queue<GameObject>();
        if(Singloton == null)
        {
            Singloton = this;
        }
        else { Destroy(gameObject); }
    }
    #endregion 

    public void SetQueue(GameObject _balas)
    {
        //caso a fila não exista
        if(Fila == null) {Fila = new Queue<GameObject>(); }
        Fila.Enqueue(_balas);
    }

    public GameObject GetBullet()
    {
        GameObject B = Fila.Dequeue(); // remover da fila
        return B; //returnar bala
    }
}
