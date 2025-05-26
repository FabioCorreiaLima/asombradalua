using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteInEditMode]  // ExecuteInEditMode faz com que o script seja executado no Editor
public class Testes : MonoBehaviour
{
    // Header permite criar um cabe�alho para as vari�veis no Inspector.
    // SerializeField permite que a vari�vel seja vis�vel no Inspector mesmo sendo privada. Ela � �til para testes e para configurar valores sem precisar mexer no c�digo.
    // Range limita o valor da vari�vel no Inspector
    // Tooltip permite adicionar uma descri��o para a vari�vel no Inspector
    [Header("Configura��es de movimento")]
    [SerializeField]
    [Range(2.0f, 12.0f)]
    [Tooltip("Velocidade do movimento da espada.")]
    private float speed = 5.0f;

    //[Header("Configura��es de vida")]
    //[SerializeField]
    //[Range(50, 200)]
    //[Tooltip("Vida da espada.")]
    //private int life = 100;

    public List<int> idades = new List<int>();

    void Start()
    {
        //Debug.Log("Speed: " + speed);
        //Debug.Log("Vida: " + life);
        idades.Add(10);
        idades.Add(20);
        idades.Add(30);
        foreach (var item in idades)
        {
            //Debug.Log("Idade: " + item);
        }

    }

    /// <summary>
    /// Update ser� chamado a cada frame. � onde a l�gica do movimento da espada ser� implementada.
    /// </summary>
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
