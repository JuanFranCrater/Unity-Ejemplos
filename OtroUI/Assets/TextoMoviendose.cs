using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoMoviendose : MonoBehaviour {
	string texto = "To be, or not to be: that is the question:\t\nWhether ’tis nobler in the mind to suffer\t\nThe slings and arrows of outrageous fortune, \nOr to take arms against a sea of troubles,\t\nAnd by opposing end them? To die: to sleep; \nNo more; and, by a sleep to say we end\t\nThe heart-ache and the thousand natural shocks \nThat flesh is heir to, ’tis a consummation\t\nDevoutly to be wish’d. To die, to sleep;\t\nTo sleep: perchance to dream: ay, there’s the rub; \nFor in that sleep of death what dreams may come \nWhen we have shuffled off this mortal coil,\t\nMust give us pause. There’s the respect\t\nThat makes calamity of so long life;\t\nFor who would bear the whips and scorns of time, \nThe oppressor’s wrong, the proud man’s contumely, \nThe pangs of dispriz’d love, the law’s delay,\t\nThe insolence of office, and the spurns\t\nThat patient merit of the unworthy takes,\t\nWhen he himself might his quietus make\t\nWith a bare bodkin? who would fardels bear, \nTo grunt and sweat under a weary life,\t\nBut that the dread of something after death, \nThe undiscover’d country from whose bourn\t\nNo traveller returns, puzzles the will,\t\nAnd makes us rather bear those ills we have\t\nThan fly to others that we know not of?\t\nThus conscience does make cowards of us all; \nAnd thus the native hue of resolution\t\nIs sicklied o’er with the pale cast of thought,\t\nAnd enterprises of great pith and moment\t\nWith this regard their currents turn awry,\t\nAnd lose the name of action. Soft you now!\t\nThe fair Ophelia! Nymph, in thy orisons\t\nBe all my sins remember’d.";
	public float _velocidad = 2.0F;
	TextMesh _comp3DText;

	void Start () {
		_comp3DText = gameObject.GetComponent<TextMesh> ();
		_comp3DText.text = texto;
	}
	

	void Update () {
		Vector3 pos = transform.position;
		Vector3 localVectorUp = transform.TransformDirection(0,1,0);
		pos += localVectorUp * _velocidad * Time.deltaTime;
		transform.position = pos;
	}
}
