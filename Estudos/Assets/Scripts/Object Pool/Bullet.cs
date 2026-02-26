using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float Speed; 
    [SerializeField] float TimeToDeactivate;

    private void OnEnable()
    {
        //(nameof)Ele substitui a necessidade de escrever nomes: strings literais
        Invoke(nameof(Deactivate), TimeToDeactivate);
    }

    private void Update()
    {
        //
        transform.Translate(transform.position * Speed * Time.deltaTime);    
    }
    void Deactivate()
    {
        gameObject.SetActive(false);
        GameManeger.Instance.SetQueue(gameObject);
    }

    private void OnDisable()
    {
        //Parar de invocar permanentemente
        CancelInvoke();
    }
}
