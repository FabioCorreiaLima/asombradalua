using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueControl : MonoBehaviour
{

    [Header("Componets")]
    public GameObject dialogueObj;  // Objeto que cont�m o di�logo
    public Image profileSprite;  // Imagem do perfil do ator
    public Text speechText;  // Texto do di�logo
    public Text actorNameText;  // Nome do ator

    [Header("Settings")]
    public float typingSpeed;  // Velocidade de digita��o

    // Vari�veis de controle
    private bool isShowing;  // Vari�vel que controla se o di�logo est� sendo mostrado
    private int index;  // Vari�vel que controla o �ndice do di�logo
    private string[] sentences;  // Vari�vel que controla a frase do di�logo

    public static DialogueControl instance;  // Vari�vel est�tica que controla o di�logo

    // Awake � chamado sempre antes do Start na hierarquia de execu��o de scripts
    private void Awake()
    {
        instance = this;
    }


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    IEnumerator TypeSentence()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            speechText.text += letter;
            yield return new WaitForSeconds(typingSpeed);  // Yield � uma palavra-chave que � usada para pausar a execu��o de um m�todo e retornar um valor
        }
    }

    // M�todo que vai servir para pular para a pr�xima fala.
    public void NextSentence()
    {

    }

    // M�todo que vai chamar a fala do NPC.
    public void Speech(string[] txt)
    {
        if (!isShowing)
        {
            dialogueObj.SetActive(true);
            sentences = txt;
            StartCoroutine(TypeSentence());
            isShowing = true;
        }
    }
}
