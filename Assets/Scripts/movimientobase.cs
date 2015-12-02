using UnityEngine;
using System.Collections;

public class movimientobase : MonoBehaviour {

	public float fuerza = 200f;
	public float velocidad_base = 100f;
	Rigidbody2D rg; //Esto es para usar el rigidbody del objeto

	// Use this for initialization
	void Start () {
		rg = GetComponent<Rigidbody2D> ();// Cargamos el rigidbody dentro de
	}
	
	// Update is called once per frame
	void Update () {
		//si pulsamos espacio saltamos

	
		if(Input.GetKeyDown(KeyCode.A)){
			rg.velocity = Vector2.zero;;
		}
		if(Input.GetKeyDown(KeyCode.D)){
			rg.velocity = Vector2.zero;;
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			mueve_izquierda ();
		}
		if(Input.GetKeyDown(KeyCode.D)) {
			mueve_derecha();
		}
		
	}

	void mueve_derecha(){
		rg.AddForce(new Vector2(velocidad_base,0));
		
		
	}
	
	void mueve_izquierda(){
		rg.AddForce(new Vector2(-velocidad_base,0));
	}
}
