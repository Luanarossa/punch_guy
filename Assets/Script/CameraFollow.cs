using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Refer�ncia ao personagem
    public Vector3 offset;   // Deslocamento inicial da c�mera em rela��o ao personagem

    void Start()
    {
        // Calcula o deslocamento inicial baseado na posi��o inicial da c�mera e do personagem
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        // Atualiza a posi��o da c�mera para seguir o personagem mantendo o deslocamento constante
        transform.position = target.position + offset;
    }
}
