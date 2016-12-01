using UnityEngine;
using System.Collections;

public class spawnFood : MonoBehaviour {

	public GameObject foodPrefab;
	public Sprite[] foodSprites;

	public void MakeRandomFood(){
		int arrayIdx = Random.Range(0, foodSprites.Length);
		Sprite foodSprite =  foodSprites[arrayIdx];
		GameObject newFood = Instantiate(foodPrefab);
		newFood.GetComponent<SpriteRenderer>().sprite = foodSprite;
	}

	// Use this for initialization
	void Start() {
		
		MakeRandomFood();
	}

	void Awake(){

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
