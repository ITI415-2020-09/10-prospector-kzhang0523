using System.Collections;
using System.Collections.Generic;
using UnityEngine;


	public enum eCardState
	{
		drawpile,
		tableau,
		target,
		discard
	}
	public class CardProspector : Card
	{ //Make sure CardProspector extends Card
	  //This is how you use the enum CardState
		[Header("Set Dynamically: CardProspector")]
		public eCardState state = eCardState.drawpile;

		//Thie hiddenBy list stores which other cards will keep this one face down
		public List<CardProspector> hiddenBy = new List<CardProspector>();

		//LayoutID matches this card to a Layout XML id if it's a tableau card
		public int layoutID;

		//The SlotDef class stores information pulled in from the LayoutXML <slot>
		public SlotDef slotDef;

	override public void OnMouseUpAsButton()
	{
		//Call the CardClicked method on the Prospector singleton
		Prospector.S.CardClicked(this);

		//Also call the base class (Card.cs) version of this method
		base.OnMouseUpAsButton();
	}

}
