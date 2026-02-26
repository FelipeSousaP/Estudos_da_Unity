using UnityEngine;

public class RingBuffers : MonoBehaviour
{
    [Header("Bullet Settings")]
    [SerializeField] int QuantidadeDeBalas;
    [SerializeField] GameObject Conteiner; 
    [SerializeField] GameObject Bullet;
    [SerializeField] GameObject Ponta;
    //2. gerar as balas antes de começar o jogo
    private void Start()
    {
        for(int i = 0; i < QuantidadeDeBalas; i++) 
        {
            GameObject NewBullet = Instantiate(Bullet,Ponta.transform.position,Ponta.transform.rotation, Conteiner.transform); //Colocando dentro do conteiner
            NewBullet.SetActive(false);
            GameManeger.Instance.SetQueue(NewBullet);
        }
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V)){
            GameObject Bala = GameManeger.Instance.GetBullet();
            Bala.SetActive(true);
        }
    }

    //3.Adicionar todass as balas em uma Array
    //4. clicar em um botão e selecinar uma bala da array
    //5. ativar a bala
}
