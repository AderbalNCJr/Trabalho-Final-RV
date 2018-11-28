using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Color2 : MonoBehaviour {

    private float Velocidade = 0.0f;
    public Color CorInicial;
    public Color CorFinal;
    private bool Repete = false;
    public int IsRunning = 1;
    private float SegundosPorCiclo = 4;
    public float ChecagemSegCicl;
    public int ContadorCiclo;
    public float TempoTotal = 0;
    float startTime;

	// Use this for initialization
	void Start () {
        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (IsRunning == 1){
			StartCoroutine (Wait());
		}
	}

	public IEnumerator Wait(){
			IsRunning = 0;
			yield return new WaitForSeconds (SegundosPorCiclo);
		if (TempoTotal < 300) {
			ContadorCiclo = ContadorCiclo + 1;

			int cor = UnityEngine.Random.Range(0, 5); //escolhendo a futura cor

			if (cor == 1)
				CorFinal = Color.red;
			if (cor == 2)
				CorFinal = Color.yellow;
			if (cor == 3)
				CorFinal = Color.blue;
			if (cor == 4)
				CorFinal = Color.green;
			


	        if (!Repete) // mudança de cor
	        {
	            float t = (Time.time - startTime) * Velocidade;
	            GetComponent<Renderer>().material.color = Color.LerpUnclamped(CorInicial, CorFinal, t);
	        }
	        else
	        {
	            float t = (Mathf.Sin(Time.time - startTime) * Velocidade);
				GetComponent<Renderer>().material.color = Color.LerpUnclamped(CorInicial, CorFinal, t);
	        }

	        CorInicial = CorFinal;

			Debug.Log (ContadorCiclo);
			IsRunning = 1;

			TempoTotal = TempoTotal + SegundosPorCiclo; //acrescentando ao tempo final

			if (TempoTotal == 60) //aumento de dificuldade a cada 60 seg
				SegundosPorCiclo = SegundosPorCiclo - 0.5f;
			if (TempoTotal > 119 && TempoTotal < 121)
				SegundosPorCiclo = SegundosPorCiclo - 0.5f;
			if (TempoTotal > 179 && TempoTotal < 181)
				SegundosPorCiclo = SegundosPorCiclo - 0.5f;
			if (TempoTotal > 239 && TempoTotal < 241)
				SegundosPorCiclo = SegundosPorCiclo - 0.5f;
		}
		else { //mudando tudo pra verde quando acabar o programa
			float t = (Time.time - startTime) * (Velocidade + 1);
			GetComponent<Renderer>().material.color = Color.LerpUnclamped(CorInicial, Color.green, t);
		}

		ChecagemSegCicl = SegundosPorCiclo;
	}
}