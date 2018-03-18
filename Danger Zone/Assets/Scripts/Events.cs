using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Events : MonoBehaviour {

	public string[][] eventQueue = new string[10][];
	public Text description;
	public Text title;
	public Button bubble1;
	public Button bubble2;
	public Button bubble3;
	public Button choice1;
	public Button choice2;
	public Button choice3;
	public Button next;
	public Button before;
	public Button after;
	public Button close;
	public Image box;
	int thing;
	Choice type1;
	Choice type2;
	Choice type3;

	/*Event Input Guide
	 * Copy in text for the following info in this order
	 * 0. Event Title
	 * 1. Main Description
	 * 2. Option 1 Text (what would go on the button itself)
	 * 3. Option 2 Text
	 * 4. Option 3 Text
	 * 5. Option 1 Type (i.e. "reserve", "explosive", or "other" for now)
	 * 6. Option 2 Type
	 * 7. Option 3 Type
	 * 8. Option 1 Result (description resulting from the choice)
	 * 9. Option 2 Result
	 * 10. Option 3 Result
	 * 11. Person 1 Word Bubble (small word bubble showing their opinion before)
	 * 12. Person 2 Bubble
	 * 13. Person 3 Bubble
	 * 14. Person 4 Bubble
	 * 15. Person 5 Bubble
	 * 16. Person 6 Bubble
	 * 17. Person 1 Suggestion (their text when you click in on them)
	 * 18. Person 2 Suggestion
	 * 19. Person 3 Suggestion
	 * 20. Person 4 Suggestion
	 * 21. Person 5 Suggestion
	 * 22. Person 6 Suggestion
	 * 23. Person 1 Response 1 (their reaction to you choosing choice 1)
	 * 24. Person 1 Response 2
	 * 25. Person 1 Response 3
	 * 26. Person 2 Response 1
	 * 27. Person 2 Response 2
	 * 28. Person 2 Response 3
	 * 29. Person 3 Response 1
	 * 30. Person 3 Response 2
	 * 31. Person 3 Response 3
	 * 32. Person 4 Response 1
	 * 33. Person 4 Response 2
	 * 34. Person 4 Response 3
	 * 35. Person 5 Response 1
	 * 36. Person 5 Response 2
	 * 37. Person 5 Response 3
	 * 38. Person 6 Response 1
	 * 39. Person 6 Response 2
	 * 40. Person 6 Response 3*/

	// Use this for initialization
	void Start () {
		for (int x = 0; x < eventQueue.Length; x++) {
			eventQueue [x] = new string[50];
		}
		type1 = choice1.GetComponent<Choice> ();
		type2 = choice2.GetComponent<Choice> ();
		type3 = choice3.GetComponent<Choice> ();
		description.enabled = false;
		title.enabled = false;
		bubble1.enabled = false;
		bubble1.image.enabled = false;
		bubble1.GetComponentInChildren<Text> ().enabled = false;
		bubble2.enabled = false;
		bubble2.image.enabled = false;
		bubble2.GetComponentInChildren<Text> ().enabled = false;
		bubble3.enabled = false;
		bubble3.image.enabled = false;
		bubble3.GetComponentInChildren<Text> ().enabled = false;
		choice1.enabled = false;
		choice1.image.enabled = false;
		choice1.GetComponentInChildren<Text> ().enabled = false;
		choice2.enabled = false;
		choice2.image.enabled = false;
		choice2.GetComponentInChildren<Text> ().enabled = false;
		choice3.enabled = false;
		choice3.image.enabled = false;
		choice3.GetComponentInChildren<Text> ().enabled = false;
		next.enabled = false;
		next.image.enabled = false;
		next.GetComponentInChildren<Text> ().enabled = false;
		before.enabled = false;
		before.image.enabled = false;
		before.GetComponentInChildren<Text> ().enabled = false;
		after.enabled = false;
		after.image.enabled = false;
		after.GetComponentInChildren<Text> ().enabled = false;
		close.enabled = false;
		close.image.enabled = false;
		close.GetComponentInChildren<Text> ().enabled = false;
		box.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void happening(){
		thing = Random.Range (0, eventQueue.Length);
		description.text = eventQueue [thing] [1];
		description.enabled = true;
		title.text = eventQueue [thing] [0];
		title.enabled = true;
		bubble1.GetComponentInChildren<Text> ().text = eventQueue [thing] [11];
		bubble2.GetComponentInChildren<Text> ().text = eventQueue [thing] [12];
		bubble3.GetComponentInChildren<Text> ().text = eventQueue [thing] [13];
		switch (eventQueue [thing] [5]) {
		case "explosive":
			type1.explosive = true;
			type1.reserve = false;
			type1.other = false;
			break;
		case "reserve":
			type1.explosive = false;
			type1.reserve = true;
			type1.other = false;
			break;
		default:
			type1.explosive = false;
			type1.reserve = false;
			type1.other = true;
			break;
		}
		choice1.GetComponentInChildren<Text> ().text = eventQueue [thing] [2];
		switch (eventQueue [thing] [6]) {
		case "explosive":
			type1.explosive = true;
			type1.reserve = false;
			type1.other = false;
			break;
		case "reserve":
			type1.explosive = false;
			type1.reserve = true;
			type1.other = false;
			break;
		default:
			type1.explosive = false;
			type1.reserve = false;
			type1.other = true;
			break;
		}
		choice2.GetComponentInChildren<Text> ().text = eventQueue [thing] [3];
		switch (eventQueue [thing] [7]) {
		case "explosive":
			type1.explosive = true;
			type1.reserve = false;
			type1.other = false;
			break;
		case "reserve":
			type1.explosive = false;
			type1.reserve = true;
			type1.other = false;
			break;
		default:
			type1.explosive = false;
			type1.reserve = false;
			type1.other = true;
			break;
		}
		choice3.GetComponentInChildren<Text> ().text = eventQueue [thing] [4];
		next.enabled = true;
		next.image.enabled = true;
		next.GetComponentInChildren<Text> ().enabled = true;
	}

	public void choose(){
		description.enabled = false;
		bubble1.enabled = true;
		bubble1.image.enabled = true;
		bubble1.GetComponentInChildren<Text> ().enabled = true;
		bubble2.enabled = true;
		bubble2.image.enabled = true;
		bubble2.GetComponentInChildren<Text> ().enabled = true;
		bubble3.enabled = true;
		bubble3.image.enabled = true;
		bubble3.GetComponentInChildren<Text> ().enabled = true;
		choice1.enabled = true;
		choice1.image.enabled = true;
		choice1.GetComponentInChildren<Text> ().enabled = true;
		choice2.enabled = true;
		choice2.image.enabled = true;
		choice2.GetComponentInChildren<Text> ().enabled = true;
		choice3.enabled = true;
		choice3.image.enabled = true;
		choice3.GetComponentInChildren<Text> ().enabled = true;
	}

	public void response(){
		description.enabled = false;
		bubble1.enabled = true;
		bubble1.image.enabled = true;
		bubble1.GetComponentInChildren<Text> ().enabled = true;
		bubble2.enabled = true;
		bubble2.image.enabled = true;
		bubble2.GetComponentInChildren<Text> ().enabled = true;
		bubble3.enabled = true;
		bubble3.image.enabled = true;
		bubble3.GetComponentInChildren<Text> ().enabled = true;
		close.enabled = true;
		close.image.enabled = true;
		close.GetComponentInChildren<Text> ().enabled = true;
	}

	public void end(){
		bubble1.enabled = false;
		bubble1.image.enabled = false;
		bubble1.GetComponentInChildren<Text> ().enabled = false;
		bubble2.enabled = false;
		bubble2.image.enabled = false;
		bubble2.GetComponentInChildren<Text> ().enabled = false;
		bubble3.enabled = false;
		bubble3.image.enabled = false;
		bubble3.GetComponentInChildren<Text> ().enabled = false;
		box.enabled = false;
		title.enabled = false;
	}

	public void result(int number){
		description.text = eventQueue [thing] [7 + number];
		description.enabled = true;
		bubble1.GetComponentInChildren<Text> ().text = eventQueue [thing] [22 + number];
		bubble2.GetComponentInChildren<Text> ().text = eventQueue [thing] [25 + number];
		bubble3.GetComponentInChildren<Text> ().text = eventQueue [thing] [28 + number];
		bubble1.enabled = false;
		bubble1.image.enabled = false;
		bubble1.GetComponentInChildren<Text> ().enabled = false;
		bubble2.enabled = false;
		bubble2.image.enabled = false;
		bubble2.GetComponentInChildren<Text> ().enabled = false;
		bubble3.enabled = false;
		bubble3.image.enabled = false;
		bubble3.GetComponentInChildren<Text> ().enabled = false;
		choice1.enabled = false;
		choice1.image.enabled = false;
		choice1.GetComponentInChildren<Text> ().enabled = false;
		choice2.enabled = false;
		choice2.image.enabled = false;
		choice2.GetComponentInChildren<Text> ().enabled = false;
		choice3.enabled = false;
		choice3.image.enabled = false;
		choice3.GetComponentInChildren<Text> ().enabled = false;
		after.enabled = true;
		after.image.enabled = true;
		after.GetComponentInChildren<Text> ().enabled = true;
	}

	public void suggest(int number){
		description.text = eventQueue [thing] [16 + number];
		description.enabled = true;
		bubble1.enabled = false;
		bubble1.image.enabled = false;
		bubble1.GetComponentInChildren<Text> ().enabled = false;
		bubble2.enabled = false;
		bubble2.image.enabled = false;
		bubble2.GetComponentInChildren<Text> ().enabled = false;
		bubble3.enabled = false;
		bubble3.image.enabled = false;
		bubble3.GetComponentInChildren<Text> ().enabled = false;
		choice1.enabled = false;
		choice1.image.enabled = false;
		choice1.GetComponentInChildren<Text> ().enabled = false;
		choice2.enabled = false;
		choice2.image.enabled = false;
		choice2.GetComponentInChildren<Text> ().enabled = false;
		choice3.enabled = false;
		choice3.image.enabled = false;
		choice3.GetComponentInChildren<Text> ().enabled = false;
		before.enabled = true;
		before.image.enabled = true;
		before.GetComponentInChildren<Text> ().enabled = true;
	}
}
