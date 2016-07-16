using UnityEngine;
using System.Collections;

public class voltearyandar : MonoBehaviour {

	public float velocidadAngular = 180.0f;
	public float velocidad = 1.0f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		/* izq o derecha?*/
		float direccion = Input.GetAxis ("Mouse X");

		/* Cuanto volteo? */
		float grados = direccion * velocidadAngular * Time.deltaTime;

		/* Copio la informacion del objeto */
		Vector3 rotacionHeroe = transform.rotation.eulerAngles;

		/* Calculo la nueva informacion */
		rotacionHeroe.y += grados;

		/* Transfiero el calculo al objeto */
		transform.rotation = Quaternion.Euler(rotacionHeroe);

		/* pa delante o patras ? */
		float pedalAceleracion = Input.GetAxis ("Vertical");

		/* Cuanto? */
		Vector3 avance = pedalAceleracion * (transform.forward * Time.deltaTime * velocidad);

		/* Transfiero la informacion del objeto */
		Vector3 nuevaposicion = transform.position;

		/* Calculo la nueva posicion */
		nuevaposicion += avance;

		/* Transfiero el calculo al objeto */
		transform.position = nuevaposicion;

	}
}
