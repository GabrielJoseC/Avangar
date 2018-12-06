using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Projectile : MonoBehaviour {

	public LayerMask collisionMask;
	float speed = 10;
	float damage = 1;

	float lifetime = 3;
	float skinWidth = .1f;

	void Start() {
		Destroy (gameObject, lifetime);

		Collider[] initialCollisions = Physics.OverlapSphere (transform.position, .1f, collisionMask);
		if (initialCollisions.Length > 0) {
			OnHitObject(initialCollisions[0], transform.position);
		}
	}
	// cria a velocidade

	public void SetSpeed(float newSpeed) {
		speed = newSpeed;
	}
//checa a velocidade, colisao
	void Update () {
		float moveDistance = speed * Time.deltaTime;
		CheckCollisions (moveDistance);
		transform.Translate (Vector3.forward * moveDistance);
	}

//checa a colisão do projetil
	void CheckCollisions(float moveDistance) {
		Ray ray = new Ray (transform.position, transform.forward);
		RaycastHit hit;

		if (Physics.Raycast(ray, out hit, moveDistance + skinWidth, collisionMask, QueryTriggerInteraction.Collide)) {
			OnHitObject(hit.collider, hit.point);
		}
	}
// o projetil da dano ao encostar 
	void OnHitObject(Collider c, Vector3 hitPoint) {
		IDamageable damageableObject = c.GetComponent<IDamageable> ();
		if (damageableObject != null) {
			damageableObject.TakeHit(damage, hitPoint, transform.forward);
		}
		GameObject.Destroy (gameObject);
	}
}
