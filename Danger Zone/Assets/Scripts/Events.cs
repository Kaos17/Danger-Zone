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
        
        //Fireball event
        eventQueue[0][0] = "Fireball";
        eventQueue[0][1] = "There’s a cacophonous boom from the bowels \
        of the ship, the shock wave of the explosion shaking your \
        nerves and rattling your brain. The deck rapidly begins to heat \
        up, and the tell tale green flames of magical fire begin to lap \
        up between the floorboards. Goodness gracious, it appears that \
        your ships is being consumed by a great ball of fire. You call \
        general quarters, and your crew works to put out the flames \
        before they consume your ship.";
        eventQueue[0][2] = "Fire Extinguisher";
        eventQueue[0][3] = "Fight Fire with Fire";
        eventQueue[0][4] = "Pray for survival";
        eventQueue[0][5] = "explosive";
        eventQueue[0][6] = "explosive";
        eventQueue[0][7] = "explosive";
        eventQueue[0][8] = "You remember that there’s a fire \
        extinguisher in case of a fire on the ship. You quickly run \
        over and hit the glass with the nearby sledge hammer. You run \
        over to the fire carrying the extinguisher carefully avoiding \
        the glass, and point it at the fire. You pull the pin and \
        squeeze the handle. The air from the room quickly rushes into \
        the canister, bringing the fire and a redshirt with it. However\
        the sudden decrease in pressure causes the engine room to groan\
        dangerously. Hopefully it doesn’t collapse on itself.";
        eventQueue[0][9] = "The phrase fight fire with more fire must \
        have come from somewhere right? Taking these ancient words into\
        account, you weave together a massive firestorm that begins to \
        consume your own ship. As quickly as it begins, you draw your \
        magic back into you, sucking in all of the flames in a massive \
        squall. It looks like the fire is out for now, but now you have\
        to deal with your ship being buffeted by the strong winds. ";
        eventQueue[0][10] = "You pull out the candles that you have \
        been saving for this very occasion and run into the fire to \
        light them. When you withdraw to the deck, you set them down in\
        a circle and begin the ritual to pray to the eldritch \
        abominations that secretly control the world. After a while of\
        muttering under your breath, you realize the rest of your crew\
        has put out the flame. Unfortunately the ritual contacted the \
        Elder Gods, and to express their displeasure, they begin to \
        rain chocolate down on your dirigible. Hopefully the balloon \
        can deal with the added weight.";
        eventQueue[0][11] = "Woah! We need an extinguisher, STAT!";
        eventQueue[0][12] = "Let us be reborn in flame!";
        eventQueue[0][13] = "Quickly, the fire extinguisher, captain!";
        eventQueue[0][14] = "Where’s the extinguisher?!";
        eventQueue[0][15] = "Do you know a spell that can stop this?";
        eventQueue[0][16] = "Have you heard the phrase, ‘fight fire \
        with fire?’";
        eventQueue[0][17] = "WHAT’RE YOU TAKIN’ TIME FOR? GET THAT FIRE\
        EXTINGUISHER!";
        eventQueue[0][18] = "Lay down your arms… an extinguisher won’t\
        kill magical flames. All we can do is pray our ship remains \
        afloat as it is purged. I will not help you fight, this time.";
        eventQueue[0][19] = "There’s an extinguisher on this ship, I \
        swear I’ve seen one. We need to find it and fast, captain!";
        eventQueue[0][20] = "There’s no time to talk! Get the fire \
        extinguisher!";
        eventQueue[0][21] = "Wait, you mean you haven’t studied water \
        magic? Only fire? Well, I don’t know, can you just absorb the \
        fire or redirect it somewhere else? It’s at least worth a \
        shot…";
        eventQueue[0][22] = "Well, and this may backfire horribly, you\
        could try shooting flames at the flames and then reabsorbing \
        them. Since they are magical flames, they must adhere to your \
        command if you mix your own with them… at least I hypothesize.";
        eventQueue[0][23] = "Where’d that fire even come from? Were we\
        attacked?";
        eventQueue[0][24] = "Okay, but why?";
        eventQueue[0][25] = "Yeah, why not! Why not sit around and hope we don’t bite it. Brilliant!";
        eventQueue[0][26] = "I was wrong… I didn’t believe the extinguisher would work, and yet here we are.";
        eventQueue[0][27] = "You’ve got guts! Not a lot of brains, but at least you’ve got guts!";
        eventQueue[0][28] = "You did not have enough faith! If you do not commit, you may as well not try!";
        eventQueue[0][29] = "Phew! That was a close call!";
        eventQueue[0][30] = "That was utterly stupid. You can’t begin to convince me that was a good idea, captain.";
        eventQueue[0][31] = "I’m speechless.";
        eventQueue[0][32] = "I thought we were toast, if I’m gonna be honest.";
        eventQueue[0][33] = "What made you think that’d be a good idea!";
        eventQueue[0][34] = "What made you even consider that, no less commit to it?";
        eventQueue[0][35] = "Well, that was terrifying.";
        eventQueue[0][36] = "Oooohh, I was wrong. I was very much wrong.";
        eventQueue[0][37] = "I’m sorry, but that was beyond braindead.";
        eventQueue[0][38] = "We’re alright, despite the odds. Bully.";
        eventQueue[0][39] = "I should have expected this, and yet I wanted to believe the old phrase.";
        eventQueue[0][40] = "Captain, if I may inquire… WHAT IN GOOD GRACIOUSNESS MADE YOU BELIEVE THAT WOULD WORK?!";
        //==============================================================
        //Crystal Storm Event
        eventQueue[1][0] = "Crystal Storm";
        eventQueue[1][1] = "You feel a wave of nausea as you watch the gathering clouds. The clouds are not an ordinary storm; it is a confluence of wild magic. These storms are unpredictable, most of your defenses won’t do much against this storm, it would probably be a good idea to avoid the storm, either by flying around it or by stopping and creating heavier wards on the ground. Forming wards would drain some of your resources, but there’s no telling what the chaotic magic would do to your ship, even at a distance. Or you could fly right into the middle of the storm. There’s no telling what secrets about the magic of the world you can see the storm.";
        eventQueue[1][2] = "Fly around";
        eventQueue[1][3] = "Create Wards";
        eventQueue[1][4] = "Fly Into Storm";
        eventQueue[1][5] = "explosive";
        eventQueue[1][6] = "reserve";
        eventQueue[1][7] = "other";
        eventQueue[1][8] = "You feel a wave of nausea as you watch the gathering clouds. The clouds are not an ordinary storm; it is a confluence of wild magic. These storms are unpredictable, most of your defenses won’t do much against this storm, it would probably be a good idea to avoid the storm, either by flying around it or by stopping and creating heavier wards on the ground. Forming wards would drain some of your resources, but there’s no telling what the chaotic magic would do to your ship, even at a distance. Or you could fly right into the middle of the storm. There’s no telling what secrets about the magic of the world you can see the storm.";
        eventQueue[1][9] = "You land the dirigible and hop down to the ground to quickly draw the wards on the ground. The magic wards crackle as jagged crystals rain from the sky and batter the wards. The wards spark, and for a moment you’re afraid that they won’t hold. However the magic in the area manages to bolster the wards, and they remain steadfast, protecting your ship.";
        eventQueue[1][10] = "The winds buffet the sides of your dirigible, and large crystals rain down on all sides. You draw a bit of power from the rogue magic, trying to help protect the dirigible from the crystals. Hopefully, your hastily woven shields will hold up.";
        eventQueue[1][11] = "We should skirt the outside and keep our distance.";
        eventQueue[1][12] = "Sail through. Magic is your ally, isn’t it?";
        eventQueue[1][13] = "Let’s go around. Wards may not protect us enough.";
        eventQueue[1][14] = "Land and ward up. I do not mess with wild magic";
        eventQueue[1][15] = "Please set us down and wait for this to blow over.";
        eventQueue[1][16] = "We would be wise to land and take shelter.";
        eventQueue[1][17] = "I’ve never seen wild magic in person, and to be honest I’m terrified… But you never move forward if you back away from your fears. Don’t take that as ‘let’s fly through the center.’ Nonono. Challenging your fears is one thing, but taking everything head on is a good way to get killed.";
        eventQueue[1][18] = "Listen, captain, I have a confession to make. I am cursed. My body is unable to die, and it has been this way for hundreds maybe thousands of years; I’ve lost count. Wild magic is dangerous and unpredictable, and it can do the impossible. If we fly through this storm head on, there’s a chance I may be freed from this wretched immortality… and I’m not about to let that go.";
        eventQueue[1][19] = "It’s not that I don’t trust your magic, captain, but wild magic is as unpredictable as it gets. I can’t think of anything more dangerous than sitting still and hoping it doesn’t break through to wreck our ship. If we go around, at least we’re in motion, and we can avoid stray wisps of magic.";
        eventQueue[1][20] = "Captain, there is only one option here. We settle down, ward up, and wait it out. Wild magic is deadly. One minute, you’re flying faster than you’ve ever flown, and the next your engine transforms into jelly. Magic storms are living nightmares, and having been young and stupid enough to fly through one once and live, I can tell you it wasn’t worth it.";
        eventQueue[1][21] = "I must admit I’ve never seen a magic storm in my life, but I’m not one to prance outside in a storm without at least an umbrella and a raincoat so that I avoid getting soaking wet, you know. I’d be happy to see it under the protection of magical wards. In fact, I’d much prefer to do so… if you don’t mind.";
        eventQueue[1][22] = "We gain nothing by trusting chance. Though magic storms may be an incredible force of nature that I yearn to investigate, doing so would put all our lives in danger or change us beyond recognition. If we burrow down and erect wards, we will be safe. I can learn about the secrets of wild magic on another day.";
        eventQueue[1][23] = "See a crystal storm up close… check. Live to tell the tale… also check.";
        eventQueue[1][24] = "Woah. Glad we landed, not gonna lie.";
        eventQueue[1][25] = "No no no! This is what I said NOT to do!";
        eventQueue[1][26] = "Perhaps mere falling crystals would not be enough to finish me anyway...";
        eventQueue[1][27] = "...";
        eventQueue[1][28] = "I shouldn’t get my hopes up… but I can’t help it! Wild magic, do your worst!";
        eventQueue[1][29] = "We’re still flying, aren’t we? We’re fine, captain.";
        eventQueue[1][30] = "We risk too much depending on wards… but we would’ve risked more had we flown around. I was wrong, captain.";
        eventQueue[1][31] = "Captain, have you lost your mind?!";
        eventQueue[1][32] = "We’re lucky to be afloat.";
        eventQueue[1][33] = "See that? Now imagine flying through… would’ve been suicide.";
        eventQueue[1][34] = "No, not through the storm! NOT AGAIN!";
        eventQueue[1][35] = "Goodness, those crystals were enormous! Thank heavens we didn’t fly through";
        eventQueue[1][36] = "It’s kind of peaceful under these wards. Terrifying, certainly, but also calm.";
        eventQueue[1][37] = "This is insanity!";
        eventQueue[1][38] = "Next time I’ll be prepared to study one of these storms. Next time.";
        eventQueue[1][39] = "I’ll study what I can behind this barrier, but one day I’ll experience it myself.";
        eventQueue[1][40] = "Have you gone completely mad?!";
        //==============================================================
        //Lightning Storm
        eventQueue[2][0] = "Lightning Storm";
        eventQueue[2][1] = "The dark clouds gathering on the horizon are a bad sign. Worse is the gathering static electricity in the storm. Good news, your dirigible should be resistant to lightning, as long as you don’t do something stupid. Bad news, your compass is spinning wildly, and the gathering winds buffet your ship, causing you to drift off of your previous course. The storm is closing on you quickly, bolts of lightning jumping between the clouds. With the strong winds and your compass disabled, you’ll probably be blown off course, but should be able to find you way once the storm passes. You could take time to use your magic to protect the compass from the storm, however you’d probably have to ground the dirigible until that passes. Speaking of doing something stupid, getting struck by lightning might give you enough of a boost to magical powers to calm the storm, however you might get blown to bits in the process.";
        eventQueue[2][2] = "Ward Navigation";
        eventQueue[2][3] = "Keep Going";
        eventQueue[2][4] = "Into the Storm";
        eventQueue[2][5] = "reserve";
        eventQueue[2][6] = "other";
        eventQueue[2][7] = "explosive";
        eventQueue[2][8] = "After landing your dirigible and setting up the lightning rods, you run over to the compass. It continues to spin wildly, but as you mutter your incantations over the compass, the needle correctly aligns itself with the north. It turns out, the storm had turned you around, but with your warded compass, you reorient yourself and continue on your way, careful to avoid lightning bolts.";
        eventQueue[2][9] = "The storms batter your ship, sending you spinning wildly. You don’t know which way you are heading, if it's out of the storm or deeper into it, not to mention that your compass is still haywire. Eventually, the storm passes, and a few minutes later you determine that you managed to get turned around in the storm and have headed backward. You reorient yourself and continue to your destination; the trip will take a few extra days though.";
        eventQueue[2][10] = "You fly into the storm, actively trying to get your ship struck by lightning. After ordering a number of the red shirts to run around with lightning rods, finally, one of them is struck by lightning. The energy flows through the ship, and you guide it to focus on the engines, hopefully charging them and sending your ship through the storm. The engines lurch, apparently reacting to this new influx of energy.";
        eventQueue[2][11] = "Without the compass, we’re flailing in the dark. Set ‘er down.";
        eventQueue[2][12] = "Embrace the lightning! Take the energy of gods!";
        eventQueue[2][13] = "A little rain won’t stop us.";
        eventQueue[2][14] = "Flying blindly without a compass is suicide. I say we fix it up.";
        eventQueue[2][15] = "Just avoid the lightning, and we’ll be right as rain. Ha!";
        eventQueue[2][16] = "I’d prefer death to inefficiency. We must land and recalibrate.";
        eventQueue[2][17] = "I’m not worried about getting struck by lightning. But I don’t act without a plan, cap, and without a compass we may be going backwards already. If it was still working, I’d say nothing more than ‘stay away from the lightning’ as we push through. I may be a risk-taker, but it’s all calculated risks and flying through a thunderstorm without a sense of direction is just dumb.";
        eventQueue[2][18] = "If you truly believe you can clear the storm by harnessing pure lightning, why would you choose any other option? When given a chance to be tested by no less than the most powerful energy in this world, how could you back down? No matter the outcome, you will leave stronger.";
        eventQueue[2][19] = "It’s just rain. If we stop now, we waste potentially hours of travel, and I can’t in good conscience allow that. This vessel is lightning resistant, correct? We have nothing to be afraid of.";
        eventQueue[2][20] = "Listen to me, there’s nothing scarier than flying through dark clouds without instruments because at any second a mountain could burst out right in front of you! We need to land and adjust our bearings; there’s no other rational choice.";
        eventQueue[2][21] = "I’ve been told ‘right as rain’ is a common expression, but I never heard my parents say it. They would say “alive-and-well-much-like-a-healthy-young-pup.” But I’m going off the train tracks and into a ditch, what were we talking about? Right. The rain. *she chuckles* I don’t think a storm like this will be too much of a problem. Just don’t get hit by lightning is all!";
        eventQueue[2][22] = "Efficiency’s the name of the game, captain. If we were to venture into the storm without the proper instruments, we won’t know whether we’re going in circle or forging ahead. Knowledge is everything, my dear friend, and if we give that up, we’re no better than those savage dinosaurs. You must repair that compass.";
        eventQueue[2][23] = "See? Risks are only as good as their payoff, and blind flying has none.";
        eventQueue[2][24] = "You didn’t have a plan, did you?";
        eventQueue[2][25] = "Why don’t you send us into the next volcano ‘just to see what happens’ while you’re at it!";
        eventQueue[2][26] = "This was a waste of time.";
        eventQueue[2][27] = "We may be set back, but you did not back down. That I can respect.";
        eventQueue[2][28] = "CAN NOTHING KILL ME?! HOW LONG MUST THIS GO ON?!";
        eventQueue[2][29] = "Now that I think about it, this was probably a better idea...";
        eventQueue[2][30] = "Well, we’re behind schedule, but at least we didn’t blow up.";
        eventQueue[2][31] = "ARE YOU TRYING TO KILL US?!";
        eventQueue[2][32] = "You made the right call, captain. Instruments are our eyes when we cannot see.";
        eventQueue[2][33] = "We’re lucky we didn’t crash. Be thankful of that.";
        eventQueue[2][34] = "We shouldn’t even be alive! That was the worst choice possible!";
        eventQueue[2][35] = "We would’ve gone the wrong way entirely if you listened to me. This is why you’re the captain.";
        eventQueue[2][36] = "That was a little more than rain. I was drastically underestimating the storm.";
        eventQueue[2][37] = "How can I trust your leadership if you’re actively trying to blow us up?";
        eventQueue[2][38] = "Terrific! Let us forge onwards!";
        eventQueue[2][39] = "That was foolish. And now we’re behind schedule.";
        eventQueue[2][40] = "Perhaps a poor choice in judgment, but, silver lining, now I can study the effects and damages of a lightning strike.";
        //==============================================================
        //Sandstorm
        eventQueue[3][0] = "Sandstorm";
        eventQueue[3][1] = "As your dirigible chugs along, the wind begins to beat harder about you. Looking out to the horizon, you see a massive wall of sand stretching across the horizon. The grimoire you brought with you has warned about massive sandstorms caused by the wild magic in the area, but you never thought that you’d see one up close. There is a small canyon that you could land in an attempt to weather the storm. Alternatively, you could attempt to pass through the storm or try and fly around the outside of the sandstorm.";
        eventQueue[3][2] = "Canyon";
        eventQueue[3][3] = "Through Storm";
        eventQueue[3][4] = "Around Storm";
        eventQueue[3][5] = "reserve";
        eventQueue[3][6] = "explosive";
        eventQueue[3][7] = "other";
        eventQueue[3][8] = "You settle down in the canyon, and the storm rolls over you. There are crackles of magical energy in the sandstorm, and you can feel the entire ship shake. Luckily most of the sandstorm passes over you, however piloting the ship out of the canyon takes more fuel than you thought.";
        eventQueue[3][9] = "As you fly through the storm, the sand tears at your ship, blasting the paint off the sides. A great bolt of lightning blasts along your ship and the timbers shudder dangerously. Your engines begin to belch black smoke, and the deck suddenly drops. Hopefully you can recover it in time.";
        eventQueue[3][10] = "You turn your ship and head to the side of the storm. With a strong push, you manage to pull just out of the path of the sandstorm, and while you’ve avoided the major danger, you will have a longer journey to get to your destination, and more chances for something to go wrong.";
        eventQueue[3][11] = "Let’s skirt the outside.";
        eventQueue[3][12] = "To retreat is dishonor.";
        eventQueue[3][13] = "Take the long way around… please.";
        eventQueue[3][14] = "I can pull us along the outskirts.";
        eventQueue[3][15] = "The storm wants to kill us; the canyon does not.";
        eventQueue[3][16] = "The ship will hold. We must push through.";
        eventQueue[3][17] = "Listen kid, I’d love to see a storm like that from the inside, but only if I get to live to tell the tale. And frankly? Flying the outskirts will be a whole lot more exciting! Imagine us riding out those crazy winds right next to these towering black clouds! Not only that, but that kind of speed will make up for lost time going around. It’s the smart choice and it’s the fun choice. Come on. Tell me that doesn’t sound awesome.";
        eventQueue[3][18] = "Strength is found in conquering weakness. You see that brewing wall of death? Now imagine pushing through it and living to tell the tale! THAT is how we improve. Tear down the walls you fear and what’s left to be afraid of? And if we go down, may it be with thunder and lightning!! If that’s what it takes to end this journey, then it is truly worthy of finishing us.";
        eventQueue[3][19] = "I’m sorry… I don’t like giving orders around, especially when it’s not my place to do so, but my parents battered it into me that “I must carry authority” and “show no hesitation” that it’s practically second-nature. If you would, please take us around the storm. Setting down and waiting takes too much time. Who knows how many hours or even days it could go on storming? At least if we skirt the edges, we’re still moving and out of harm’s way.";
        eventQueue[3][20] = "We’d best steer around the outskirts. Sure, maybe we can sit tight in a canyon, but then we’re just waiting for a disaster to break us in half, not to mention the fuel it’ll cost to bring us airborne again. I say we stay in motion and go the long way. It’s more important to make it home then it is to race the clock.";
        eventQueue[3][21] = "I’ve never seen something so monstrous and, to be curt, bloody terrifying… If we want to keep our britches out of the way of puddles, we’d best sit tight in that canyon. Please, for my sake, don’t charge into the mouth of the particularly hungry alligator that at this point is no longer hidden due to the certainty it feels about killing us.";
        eventQueue[3][22] = "Can you feel that? I’ve heard it described to me before, but I’ve never experienced it with such heavy intensity: the calm before the storm, my friend. My heart is quick, my hair is standing on end… This is… brilliant. I’ve never seen such a magnificent bulk of looming clouds in my life. I’m not dropping this opportunity, captain. Take us through.";
        eventQueue[3][23] = "Jegus, that took forever. Next time, maybe think about what I said?";
        eventQueue[3][24] = "Okay, not gonna lie, I wanna do that again. I’ve never felt adrenaline like that before in my life -- and I’ve been shot before!";
        eventQueue[3][25] = "Hahaha! Yes! That’s what I’m talkin’ about! We make a pretty good team, don’t we, cap?";
        eventQueue[3][26] = "*grumbling* Yet another opportunity wasted, yet another day I live…";
        eventQueue[3][27] = "A mighty fine eruption! And yet, I still draw breath… Clearly the storm was unworthy of finishing me off.";
        eventQueue[3][28] = "You’ll never overcome anything if you choose to run away.";
        eventQueue[3][29] = "At least we’re safe… can’t be too upset about that.";
        eventQueue[3][30] = "If you’re trying to get us killed… well, you’ve… nearly gone and done it! Please be more careful, captain. I have...someone waiting for me... back home.";
        eventQueue[3][31] = "I really appreciate this. We may be behind schedule, but it was the best option presented to us. Thank you, captain.";
        eventQueue[3][32] = "We coulda saved on fuel, but I suppose we’re still alive.";
        eventQueue[3][33] = "GREAT. Very fine choice, captain. Next time, why don’t you steer us into a mountain!";
        eventQueue[3][34] = "Good call, cap. We’re a little behind schedule, but storms’ll do that.";
        eventQueue[3][35] = "Wonderful! If we’d decided to brave the storm I imagine my wits would’ve gone parachuting.";
        eventQueue[3][36] = "*shaking* You know, we’ll never make it through this if we toss ourselves into pits of feral raptors at every given opportunity. Please don’t ever do that again.";
        eventQueue[3][37] = "I thought going around would be quite literally next to the storm.  *chuckling*  Glad I was mistaken!";
        eventQueue[3][38] = "Perhaps I should have specified… I wanted us to fly through the storm, captain.";
        eventQueue[3][39] = "I could have sworn the ship would hold. My apologies captain. I am to blame for such a miserable circumstance.";
        eventQueue[3][40] = "How could you… we had opera house seats to few the finest disaster I’ve ever witnessed, and you back away?! I hope you know what you’ve done.";
        //==============================================================
        //Scrapper
        eventQueue[4][0] = "Scrapper";
        eventQueue[4][1] = "The skies are clear and out on the horizon; you can see an airship moving to intercept you. You can just make out a crudely painted gear on the side of their balloon; they’re members of the Tinker’s Guild, the rivals of your Wizard College. The hail you as they approach and their captain shouts over to you, “Aight mates, we’re not looking for a fight. We’re gonna take one of the many things you got strapped to your ship, and we’ll be on our way. Savvy?”";
        eventQueue[4][2] = "Fight";
        eventQueue[4][3] = "Run";
        eventQueue[4][4] = "Surrender";
        eventQueue[4][5] = "other";
        eventQueue[4][6] = "explosive";
        eventQueue[4][7] = "other";
        eventQueue[4][8] = "You decide against helping your rivals, and ready a fireball to throw at their ship. They can see you gathering magical energies and point a cannon crackling with electrical energy at you. You hurl a fireball just as they fire their cannon, hopefully your ship will survive.";
        eventQueue[4][9] = "You quickly let out enough air in your balloon to slip under their ship. As the scrappers pass over you, you kick your engines into high gear, trying to outrun them. Hopefully, the added strain doesn’t cause you to explode.";
        eventQueue[4][10] = "They are surprisingly civil about stealing part of your ship. The Scrappers attach some lines to an augment, and scamper across and in less than ten minutes have removed it entirely from your ship. As they turn away from you, the captain waves goodbye and they head off in a completely different direction than you.";
        eventQueue[4][11] = "Let’s take these fools";
        eventQueue[4][12] = "If it’s a fight they want,  it’s a fight they’ll get!";
        eventQueue[4][13] = "Don’t give them what they want";
        eventQueue[4][14] = "We can outrun them they’re not worth it";
        eventQueue[4][15] = "We don’t need to fight them, do we?";
        eventQueue[4][16] = "Hold fast. Let them try to steal from us and live";
        eventQueue[4][17] = "Tinkers are worthless half-pirates at best. If they had any guts, they’d throw off that thin veil and own their criminal scheme with a blazing smile! I can’t stand cowards and thieves. If you’re going to be sneaky, at least be clever enough to hide it so people can’t see you for what you are. So I say we show them what a real fight looks like, and blast them out of the sky!";
        eventQueue[4][18] = "I have never been robbed in all my years. At least, those who tried never lived to see the next day. And these scrawny pukes would have the gall to try and steal from us without a proper fight? I’d gladly give them the taste of cold steel before letting their grubby paws take what’s mine. Let’s send these scum to their makers.";
        eventQueue[4][19] = "I’m not going to just let you give in to these wretched thieves. Although I fear they may be able to back up their words, we can’t just let them win. They think they can take what they want and get away with it without any consequences, but I want you to show them otherwise. Whether that means taking them on or taking our leave is up to you. I trust your judgement, captain.";
        eventQueue[4][20] = "I’ve dealt with Tinkers enough times to know it always ends in either a headache or serious damage to the ship. I say we skip the trouble altogether and leave them in the dust. Seriously, if I had a nickel for every time a Tinker wasted my time I could put my kids through college twice.";
        eventQueue[4][21] = "They seem like nice enough folks. They offered not to blast us away with their cannons, so they might be somewhat reasonable people… Perhaps they’d be willing to offer us a treaty of kinds in which we mutually agree not to destroy each other in exchange for a small piece of our ship?... They already said that? Oh! Well, I don’t see why we can’t trade away something to secure our safety.";
        eventQueue[4][22] = "If they are so inclined as to rob us, I say we rob them of their lives in return. They disrespect our agency by asking that we stand by. Ridiculous, I say. If they truly believe that they can take a piece of our vessel without recompense, let them fall to the consequences of their tomfoolery. If they had a pinch more intelligence, they wouldn’t have asked.";
        eventQueue[4][23] = "Hahaha! Nice shot captain! Take that!";
        eventQueue[4][24] = "We could’ve taken them…";
        eventQueue[4][25] = "I can’t believe you let those half-cocked crooks steal from us.";
        eventQueue[4][26] = "That’ll teach them to keep their hands to themselves. Well fought, captain.";
        eventQueue[4][27] = "Blast it all, I was ready to take their heads off!";
        eventQueue[4][28] = "There go the first men to steal from me and live… How infuriating.";
        eventQueue[4][29] = "I’m sorry they had to die… but their actions have consequences, and you made the right choice.";
        eventQueue[4][30] = "Let’s hope they don’t follow us, captain";
        eventQueue[4][31] = "Dealing with criminals and letting them go… you’re beginning to remind me of my parents.";
        eventQueue[4][32] = "Woah woah woah! We didn’t hafta kill ‘em! I’m not honestly upset, but that was overkill.";
        eventQueue[4][33] = "Yeah! Let’s give ‘em the slip!";
        eventQueue[4][34] = "Another ten minutes of my life down the drain.";
        eventQueue[4][35] = "Captain! That was needlessly brutal! It was only one augment they wanted!";
        eventQueue[4][36] = "Oh! Well, I really can’t complain, just a bit startled.";
        eventQueue[4][37] = "I was hoping I could talk to one of them and learn a bit about their lives, but they were never close enough. What a shame.";
        eventQueue[4][38] = "Hah. Fools.";
        eventQueue[4][39] = "Now they’ll never learn. Truly a botched opportunity.";
        eventQueue[4][40] = "To say I am disappointed would be an understatement. Who knows if they’ll ever be taught a lesson.";
        //==============================================================
        //Snakes on a Blimp
        eventQueue[5][0] = "Snake on a Blimp";
        eventQueue[5][1] = "There’s a clatter from the storeroom, and one of your redshirts come running out covered in a writhing mass of snakes. Apparently, someone thought it would be a funny prank to put a can of snakes on the dirigible. Either way, you are now going to have to deal with this problem. You can throw them overboard, or probably just ignore them. As you contemplate this dilemma, one of the redshirts runs out with a large cross between a shovel and a pitchfork and the snakes quickly consumes him. Perhaps ignoring them is a bad idea, although the redshirts will keep them busy.";
        eventQueue[5][2] = "Ignore snakes";
        eventQueue[5][3] = "Magically Remove Snakes";
        eventQueue[5][4] = "Shovel Time";
        eventQueue[5][5] = "explosive";
        eventQueue[5][6] = "reserve";
        eventQueue[5][7] = "other";
        eventQueue[5][8] = "Not wanting to spend precious resources with this strange situation, you decide the best way to deal with it is to deal with it the same way you dealt with studying spells, ignore it and hope it goes away. No doubt some of the redshirts will be bitten, but hopefully, the snakes don’t slither into the engines and cause too many issues.";
        eventQueue[5][9] = "Having enough of these snakes on your blimp, you channel your magic to gather the snakes together into a giant orb, then telepathically hurl it over the side of the ship. The snakes plummet to the ground below, and you can hear a wet splat as they impact below.";
        eventQueue[5][10] = "You knew it was a good idea to bring a shovel on a dirigible, and who’s laughing now. Arming yourself with your trusty spade, some thick gloves, and boots, and a bandana because why not, you step out onto the deck and begin to “de-snakify” the blimp. Beating snakes to death with a shovel is so much more cathartic than just casting spells to do it. The blood of too many of the serpents stains the deck of your ship. At least you won’t need to worry about food for a while. Hopefully, your rampage didn’t damage the gondola too much.";
        eventQueue[5][11] = "Cap’n… get the shovel. This is about to get awesome.";
        eventQueue[5][12] = "Ready to bash some skulls, captain?";
        eventQueue[5][13] = "I don’t care! Just get rid of them!";
        eventQueue[5][14] = "Send those scaly scoundrels overboard!";
        eventQueue[5][15] = "The poor things are frightened! Leave them to me.";
        eventQueue[5][16] = "I’d actually prefer to study them, if you don’t mind.";
        eventQueue[5][17] = "Now would be a good time for a one liner and some explosions, don’t you think? -Not explosions of our blimp- … you know what I mean.";
        eventQueue[5][18] = "Just picture it, captain. The two of us, side-by-side, hacking away at the masses of serpents. Glorious is it not? Imagine the story you’ll tell for years to come!";
        eventQueue[5][19] = "Christ, just throw them overboard or kill them already! … I’m sorry. I know it’s not that simple, I just… I don’t wanna get poisoned and die, alright? Just do what you have to.";
        eventQueue[5][20] = "Oh for the love of- These things are in every dang nook and cranny! I swear, I have just about about had it with these murder-fanged snakes on this multifaceted plane-- I mean blimp!";
        eventQueue[5][21] = "I know it’s a lot to ask, but please don’t kill them. Some twisted ruffian shoved them into a can for who knows how long! Of course the moment they’re free they’re going to panic and attack anything near them because that’s what I’d do if I were squished into a box with more humans than could possibly be considered safe or necessary! Just trust me; I will pacify them.";
        eventQueue[5][22] = "Believe me, I’ve studied my fair share of reptiles, but never so many in such a cramped space. I’m insatiably curious to see the effects air travel and altitude have on the daily lives of these specimens. I understand that they pose a threat to our very safety, but I promise to make it worth your while.";
        eventQueue[5][23] = "Wait a tick… none of these are poisonous snakes…";
        eventQueue[5][24] = "Well… that works, but it’s not as cool as what I had in mind…";
        eventQueue[5][25] = "Ahahaha! Woo! Yeah, way to GO cap!";
        eventQueue[5][26] = "You can’t make me promise not to kill any";
        eventQueue[5][27] = "I didn’t even get to kill ANY";
        eventQueue[5][28] = "...Today was a good day...";
        eventQueue[5][29] = "This was the ONLY WRONG OPTION!";
        eventQueue[5][30] = "That’s one way to do it. Phew!";
        eventQueue[5][31] = "Wow… who knew snakes could have so much blood in them?";
        eventQueue[5][32] = "Welp. Guess we won’t have any rat problems in the future.";
        eventQueue[5][33] = "Well that was weird.";
        eventQueue[5][34] = "Crimeny, that was brutal... Maybe I shoulda grabbed a shovel too.";
        eventQueue[5][35] = "They love meeee! Thanks for trusting me.";
        eventQueue[5][36] = "...But none of them were poisonous…";
        eventQueue[5][37] = "Why? Why such violence? They weren’t poisonous!";
        eventQueue[5][38] = "Spectacular! Time for some research!";
        eventQueue[5][39] = "Fiddlesticks. I could have learned so much…";
        eventQueue[5][40] = "Well, that was particularly savage. But I would be lying if I said I wasn’t stimulated by such pure adrenaline.";
        //==============================================================
        //Volcano
        eventQueue[6][0] = "Volcano";
        eventQueue[6][1] = "You feel the air get dryer and much warmer. There seems to be a wellspring of fire magic in this area turning the terrain into active volcanoes. Good thing you crew has wards against lava. One of the volcanoes erupts and spews molten rocks at your ship, punching a hole in the deck next to you. Apparently, the illustrious designers thought that the ship should be susceptible to flaming rocks. At least the paint isn’t flammable. As another volcano erupts, it crosses your mind that maybe this isn’t the best place to bring a wooden ship. You could quickly turn around and find a different path around. Or you can place faith in the craftsmanship of your dirigible. After all, it has never failed you before.";
        eventQueue[6][2] = "FULL SPEED!";
        eventQueue[6][3] = "Hard About";
        eventQueue[6][4] = "Gain Altitude";
        eventQueue[6][5] = "explosive";
        eventQueue[6][6] = "explosive";
        eventQueue[6][7] = "explosive";
        eventQueue[6][8] = "You charge directly ahead into the flames. The lava and magma spews up and batters your ship, the crew running around frantically to put of the flames. Nearby eruptions batter your ship, and cause you to rock dangerously.";
        eventQueue[6][9] = "You quickly turn the dirigible around, desperately trying to avoid the lava that is hurtling towards you. It splatters on board the vessel with a hiss, but a liberal application of magic spells prevent it from doing too much damage. Unfortunately finding a new path will take a significant amount of time.";
        eventQueue[6][10] = "Keeping a flammable ship near fire is probably a bad idea, so you should get the heck out of dodge. You disable the hover controls, and the magic keeping the dirigible at the same altitude shut down for a moment, but it’s enough time for your ship to jump up a solid fifteen feet. It’s enough to avoid some of the lava, but you’re going to be cleaning the storerooms for the next week.";
        eventQueue[6][11] = "Volcano! Get us out of here!";
        eventQueue[6][12] = "Full ahead! We can take it!";
        eventQueue[6][13] = "Turn back! Turn back, captain!";
        eventQueue[6][14] = "WOAH! Turn around! Turn around!";
        eventQueue[6][15] = "Go back! We’ll blow up for sure!";
        eventQueue[6][16] = "We’ve come this far already! Push through!";
        eventQueue[6][17] = "We don’t have time to talk! That’s a volcano! End of discussion!";
        eventQueue[6][18] = "We’ll be fine, trust me. It’s only a volcano.";
        eventQueue[6][19] = "I meant NOW captain! Get us out of here before we’re burnt to a crisp!";
        eventQueue[6][20] = "We don’t have time to chat! It’s either turn around and survive or keep going and die horribly!";
        eventQueue[6][21] = "Now’s not the time! Go back! Go back before we’re blown to bits!";
        eventQueue[6][22] = "If we turn around now, we’ll have to go back through that same volcano! We carry on and hope for the best. We risk the same by turning back!";
        eventQueue[6][23] = "Noooo!";
        eventQueue[6][24] = "That was a close call.";
        eventQueue[6][25] = "PLACEHOLDER";
        eventQueue[6][26] = "I was certain that lead to a glorious death… blast it all";
        eventQueue[6][27] = "I’m disappointed, but not surprised. We would have been fine.";
        eventQueue[6][28] = "PLACEHOLDER";
        eventQueue[6][29] = "I don’t wanna die!";
        eventQueue[6][30] = "That’s quite enough excitement for one day, don’t you think?";
        eventQueue[6][31] = "PLACEHOLDER";
        eventQueue[6][32] = "No…";
        eventQueue[6][33] = "Guess we’ll have to put that on our map for future reference… There’s volcanoes there now";
        eventQueue[6][34] = "PLACEHOLDER";
        eventQueue[6][35] = "Aaaaaaaaahhh!";
        eventQueue[6][36] = "I’m just glad we’re okay. My heart is still pounding.";
        eventQueue[6][37] = "PLACEHOLDER";
        eventQueue[6][38] = "Oh dear.";
        eventQueue[6][39] = "You navigated the flames much better on your way out. Perhaps this was the right choice after all.";
        eventQueue[6][40] = "PLACEHOLDER";
        //==============================================================
        //Tinker
        eventQueue[7][0] = "Tinker";
        eventQueue[7][1] = "On the horizon, you can see a small hot air balloon. There is a single man inside, and he hails you by waving a flag in you signal you over. You steer your ship next to him, and he tosses a rope over to you. After securing himself to your ship, he nervously looks around while ringing his hands. “Good day to you kind sir and or madam. I am a humble merchant, simply selling my wares.” He gestures to his balloon, and you notice some smaller balloons tied to the back. “I have many fine wares that I’ve found in the region if you would be willing to trade for it.”";
        eventQueue[7][2] = "Trade";
        eventQueue[7][3] = "Don't Trade";
        eventQueue[7][4] = "You be the Dread Pirate";
        eventQueue[7][5] = "other";
        eventQueue[7][6] = "other";
        eventQueue[7][7] = "other";
        eventQueue[7][8] = "You decline his offer, and the man nods, “Alright then, I might see you around later than.” He then steers off into the horizon.";
        eventQueue[7][9] = "You decline his offer, and the man nods, “Alright then, I might see you around later than.” He then steers off into the horizon.";
        eventQueue[7][10] = "You begin casting a spell and the Tinker lets out a shriek. He pulls out a bowling ball and throws it onto your deck, the sudden increase in your weight causes the ship to rock, and he rises in the air. He beats a hasty retreat, and you manage to toss the ball overboard. However it takes extra fuel to get back to your previous altitude.";
        eventQueue[7][11] = "He’s too scrawny to be any threat. If you wanna trade, go for it.";
        eventQueue[7][12] = "He’s not going to rob us. Do what you please.";
        eventQueue[7][13] = "It would be nice if we knew what he was selling exactly…";
        eventQueue[7][14] = "Well, now that he’s here, I suppose we could always use more augments.";
        eventQueue[7][15] = "I wish he would let me see his wares before I commit to a purchase…";
        eventQueue[7][16] = "I don’t care either way.";
        eventQueue[7][17] = "He’s no pirate. We might have some stuff we can trade in storage for an augment. Though I don’t know if he’ll let us choose which one…";
        eventQueue[7][18] = "It makes no difference to me whether you want to trade with him or not.";
        eventQueue[7][19] = "He seems legitimate enough. Do we want to add more to the ship or not?";
        eventQueue[7][20] = "Keep an eye on the augment he gives us. It might not be useful.";
        eventQueue[7][21] = "“For a humble merchant selling his wares, it’s strange to me that we don’t get to see the selection.";
        eventQueue[7][22] = "What do you want from me? It’s your decision. I’ve made that clear.";
        eventQueue[7][23] = "I hope it’s not explosive.";
        eventQueue[7][24] = "What’s that supposed to mean?";
        eventQueue[7][25] = "PLACEHOLDER";
        eventQueue[7][26] = "...";
        eventQueue[7][27] = "I do not care for that man.";
        eventQueue[7][28] = "";
        eventQueue[7][29] = "Let’s get this installed right away.";
        eventQueue[7][30] = "He seemed… nice.";
        eventQueue[7][31] = "PLACEHOLDER";
        eventQueue[7][32] = "...I hope it’s not dangerous. I shoulda thought of that earlier.";
        eventQueue[7][33] = "Let’s get going. We’ve been standing around long enough.";
        eventQueue[7][34] = "PLACEHOLDER";
        eventQueue[7][35] = "What an odd fellow. Shouldn’t there be a back and forth when bartering?";
        eventQueue[7][36] = "Goodbye!";
        eventQueue[7][37] = "PLACEHOLDER";
        eventQueue[7][38] = "Brilliant. Can we move along?";
        eventQueue[7][39] = "It’s about time he left.";
        eventQueue[7][40] = "PLACEHOLDER";
        //==============================================================
        //Chickens
        eventQueue[8][0] = "Chickens";
        eventQueue[8][1] = "It is calm as you travel the route. The winds are quiet and there’s no storm gathering on the horizon. It is entirely calm, almost too calm. Suddenly chickens. They just appear. Everywhere. All over the ship. Like so many chickens. It’s a chicken-pocalypse. And it is not too annoying, they just are kind of there and wander around the ship. However they might make a nest in the engine room, so it might be best to remove them, probably violently.";
        eventQueue[8][2] = "Ignore Chickens";
        eventQueue[8][3] = "Remove Chickens";
        eventQueue[8][4] = "FIGHT! FIGHT! FIGHT!";
        eventQueue[8][5] = "other";
        eventQueue[8][6] = "other";
        eventQueue[8][7] = "explosive";
        eventQueue[8][8] = "You ignore the chickens, and they tend to ignore you. However, now you have chickens on your dirigible. Yay? ";
        eventQueue[8][9] = "In order to deal with the numerous chickens, you decide to turn them into a more manageable form. As the final words of your polymorphs spell ends, there is a bright flash of light, and the chickens are turned into more redshirts to replace the ones you lost so far in your journey.";
        eventQueue[8][10] = "Without feather ado, you charge at the chickens, swinging a monkey wrench. Unfortunately, chickens are resistant to monkey wrenches, or these are just magical chickens because as you hit them, they just sit there staring at you. After about six good whacks, the chicken caws, and all of them turn to you and charge, a flurry of angry poultry and feathers. Your first instinct is to punt the chickens away from you, and one of them sails into the engine, which explodes in a brilliant gout of flame.";
        eventQueue[8][11] = "They were cute at first, but now they won’t shut up.";
        eventQueue[8][12] = "They’re hardly worth the effort";
        eventQueue[8][13] = "I wouldn’t mind them if it weren’t for the smell.";
        eventQueue[8][14] = "These chickens are a nuisance. Let’s get rid of them.";
        eventQueue[8][15] = "They’re just so cute! I can’t get enough of them!";
        eventQueue[8][16] = "I grew up on a farm, and nostalgia is competing with my better judgement.";
        eventQueue[8][17] = "I like looking at them, sure, but I don’t think I could live like this for more than an hour. They just. keep. clucking. It’s like there’s no end. Not to mention I’ve no idea how many are on this blasted ship. I’m not going to catch a wink of sleep tonight if they stay. They need to go.";
        eventQueue[8][18] = "It’s only poultry. Worst case scenario, you cook the ones that bother you and we all eat well. If you find chickens to be so distracting, how are you ever going to deal with a real problem?";
        eventQueue[8][19] = "I liked them at first. I was petting one and he was becoming quite friendly with me, but then it… well… pooped… on the floor and the smell just... I swear I’ve never smelt anything so rancid! With this many chickens aboard, it’ll be no time at all before this ship becomes a dung heap!";
        eventQueue[8][20] = "We can’t keep them. We don’t have the space to care for them, or food enough to feed them, or… they can’t stay on board, all right? If that’s not bad enough, their weight might actually be slowing us down. We need to kick ‘em off, and soon.";
        eventQueue[8][21] = "I’d like you meet Clark. He is my chicken friend, and I love him <3. And I love Alan, this one too! And this one! And… well I love them all! They’re all my little babies and I won’t let you throw them off. They haven’t done anything wrong, and they’re just so precious! *She kisses Clark on the head*";
        eventQueue[8][22] = "I grew up with chickens up until my late teenage years. The smell, the sound… it just… makes me think of a simpler time. Perhaps such feelings are a weakness. However, they are not without use. We can eat them and their eggs if we so choose. I only ask that you let them be… for my sake.";
        eventQueue[8][23] = "If I can’t sleep, I’m making sure you don’t either.";
        eventQueue[8][24] = "PLACEHOLDER";
        eventQueue[8][25] = "That was weirdly satisfying… does that make me a bad person?";
        eventQueue[8][26] = "It appears I’ve made a friend. *a chicken rests on his head*";
        eventQueue[8][27] = "PLACEHOLDER";
        eventQueue[8][28] = "Why didn’t you tell me we’d be bludgeoning them in the first place? That was the most fun I’ve had in years!";
        eventQueue[8][29] = "Okay, so who’s going to clean up after them?";
        eventQueue[8][30] = "PLACEHOLDER";
        eventQueue[8][31] = "Okay… *phew* Nobody open that door, got it?";
        eventQueue[8][32] = "When life gives you eggs, I guess all you can do is make omelettes";
        eventQueue[8][33] = "PLACEHOLDER";
        eventQueue[8][34] = "That was brutal. Let’s never talk about this again.";
        eventQueue[8][35] = "I swear I’ve died and gone to a heaven made specifically for chickens!";
        eventQueue[8][36] = "PLACEHOLDER";
        eventQueue[8][37] = "You didn’t have to beat them!! We could’ve just… that was atrocious!";
        eventQueue[8][38] = "Perhaps I underestimate nostalgia. Perhaps it serves a greater purpose...";
        eventQueue[8][39] = "PLACEHOLDER";
        eventQueue[8][40] = "I feel as though part of my childhood just perished.";
        //==============================================================
        //Dread Pirate Scott
        eventQueue[9][0] = "Dread Pirate Scott";
        eventQueue[9][1] = "On the horizon you see another airship heading towards your ship. Its balloon is black with a white skull painted on the side. At the bow of the ship is a man with wild hair and a tattered coat. He raises a cutlass and points toward you ship shouting “Yarg! I be the Dread Pirate Scott! Prepare to be boarded and your booty plundered!” His ship lurches, and he stumbles to the side, nearly falling overboard. However, their ship is still bearing down on you. You could turn and run, but this guy also seems like a joke, you could probably take his crew in a fight.";
        eventQueue[9][2] = "Fight";
        eventQueue[9][3] = "Run";
        eventQueue[9][4] = "Evasive Maneuvers";
        eventQueue[9][5] = "other";
        eventQueue[9][6] = "explosive";
        eventQueue[9][7] = "other";
        eventQueue[9][8] = "As you bring your ship to attack positions, Scott swings from a rope trying to make it to your ship. He sails through the air, but a quick spell stops his momentum, and he plummets to the ground below. The rest of his crew stare at each other for a moment before resuming their attack.";
        eventQueue[9][9] = "Discretion is the better part of valor. And has better survival chances. You quickly turn your ship to avoid the pirates, you’re reasonably confident that you can outrun them. Scott yells at his crew to follow you, and they lob various spells at your ship. You manage to avoid most of them, but a lucky shot damages your engine. However, during Scott’s celebration, he trips and falls overboard. As his crew falls to squabbling over who is in charge now, you manage to slip away. Hopefully, your engine holds up.";
        eventQueue[9][10] = "You turn you dirigible around quickly and let out air from your balloon, trying to duck under their ship. This maneuver goes poorly, and you just end up ramming into their ship. There’s a groan as the two ships grind against each other, smearing the Dread Pirate Scott between the two decks. Realising that their captain is dead, the crew breaks into a squabble about who is the new captain, and you continue on your way unimpeded.";
        eventQueue[9][11] = "Wow, what a loser. Let’s take him down a peg.";
        eventQueue[9][12] = "He’s not worth the effort.";
        eventQueue[9][13] = "We have more pressing matters at hand than this buffoon.";
        eventQueue[9][14] = "Do we need to run from this guy?";
        eventQueue[9][15] = "Must we fight? He seems harmless.";
        eventQueue[9][16] = "Waste this fool.";
        eventQueue[9][17] = "Please let me kill him. This idiot makes sky pirates look like a buncha chumps! As a soon-to-be pirate Queen myself, I’m insulted that a moron like this exists and represents my future line of work. If we run away, we’re no better- actually, no, we’re worse than that guy ‘cuz that means he wins.";
        eventQueue[9][18] = "I’m always poised for battle, captain. Always. But to fight this reckless child would be neither challenging nor glorious. We only waste time by lowering ourselves to his playing field, so I’d say we’re better off leaving him in the dust. If he catches up and attacks us, fine; I’ll choke him out and be done with it, but let’s not force such a pointless engagement.";
        eventQueue[9][19] = "I could literally list at least 15 other things off the top of my head that would be more worthwhile than fighting this overzealous clown, captain. Don’t engage his ridiculous charade.";
        eventQueue[9][20] = "Normally, I avoid tussles with pirates... but this guy needs a good punch to the face. We’d be wasting fuel trying to outrun someone who’s barely threatening. I say we teach him a lesson the old fashioned way and be done with it.";
        eventQueue[9][21] = "‘Dread Pirate Scott,’ hmm? Does this loony actually intend to fight us, or just flail wildly while trying to look impressive? Frankly, he’ll die if he tries to board us, so why don’t we just skip this one? I’m more afraid he’ll end up killing himself with his clumsiness and I’d rather not see how he’d even manage to do so.";
        eventQueue[9][22] = "He calls us out as though he owns the skies, yet he can barely scare an infant with his friendly visage and clumsy footing. This jester mocks us with his hollow threats; I would be thoroughly offended if he were allowed to live. Humankind doesn’t need more tomfoolery in its bloodline.";
        eventQueue[9][23] = "I wanted a fight… but this priceless.";
        eventQueue[9][24] = "Ah man, I wanted to kill him!";
        eventQueue[9][25] = "PLACEHOLDER";
        eventQueue[9][26] = "Hmph. Bottom-feeders, the lot of them.";
        eventQueue[9][27] = "Some dread pirate…";
        eventQueue[9][28] = "PLACEHOLDER";
        eventQueue[9][29] = "Okaaay… that was a thing.";
        eventQueue[9][30] = "Good riddance.";
        eventQueue[9][31] = "PLACEHOLDER";
        eventQueue[9][32] = "That turned out way better than I could’ve expected.";
        eventQueue[9][33] = "Hahaha! Oh that is gold!";
        eventQueue[9][34] = "PLACEHOLDER";
        eventQueue[9][35] = "I’d feel bad for poor captain Scott if his death wasn’t so funny.";
        eventQueue[9][36] = "Should I feel bad for the ‘dread pirate scott?’ Because that was hilarious.";
        eventQueue[9][37] = "PLACEHOLDER";
        eventQueue[9][38] = "Good. Those brigands deserve nothing more.";
        eventQueue[9][39] = "I can’t honestly express disappointment… ‘the Dread Pirate Scott’ still died in the end.";
        eventQueue[9][40] = "PLACEHOLDER";
        //==============================================================
                //Missionary
        eventQueue[10][0] = "Missionary";
        eventQueue[10][1] = "You can see on the horizon, a small dirigible with a snake wrapped around a gear. A man dressed in a tan robe waves you over. The man smiles as you approach, “Hail and well met my dudes. I’m on an expedition to find inspiration in these parts. You see, I’m a member of the Church of Tad and Nathan, and I’m looking for something to inspire me to design better dirigibles. As I’m sure you are aware, the current design goes against everything that the Tinker’s Guilds promote. We did not fight against the authoritarian regime of the Wizard Houses to work with them to design these atrocious looking dirigibles with less than seventeen loops. We fought for our freedom, not to be constrained by arbitrary rigid structures to fill with hot air!” You don’t know where this man came from, or what he’s done but he’s probably insane. He seems to be fishing to see if you agree with his ideas about the dirigibles being a bad idea. You could either agree with him or disagree. There’s no telling what will happen if you disagree, so you should either get ready to fight, run or just go past him and pretend he doesn’t exist.";
        eventQueue[10][2] = "The Design Sucks";
        eventQueue[10][3] = "The Design is Awesome";
        eventQueue[10][4] = "Float Away";
        eventQueue[10][5] = "other";
        eventQueue[10][6] = "reserve";
        eventQueue[10][7] = "other";
        eventQueue[10][8] = "Excellent! A fellow believer! Just give me a moment, and I can condemn this terrible design.” He waves his hands in vaguely magical patterns, “By the powers vested in me by the Church of Tad and Nathan I condemn this dirigible to the aether.” He stops waving his hands, pulls out a wrench and whacks your blimp, causing one of your augments to fall off. He then waves, “Have a swell day sir and or madam,” and continues on his mad quest.";
        eventQueue[10][9] = "He reaches for his wrench, and your ship lurches forward as it launches into full speed. You manage to avoid his mad swinging skills, and he slowly dwindles on the horizon. Unfortunately, it did take some of your magical energy to get away from him.";
        eventQueue[10][10] = "You’ve had your fill of weirdness for the day and think better of investigating this strange person. The form of his dirigible slowly disappears as you continue on your way.";
        eventQueue[10][11] = "This guy’s a lunatic. Just smile and agree.";
        eventQueue[10][12] = "He spews nonsense.";
        eventQueue[10][13] = "Well I agree, but not as enthusiastically.";
        eventQueue[10][14] = "I dunno what this guy’s talking about.";
        eventQueue[10][15] = "Truthfully, I think the he has a point.";
        eventQueue[10][16] = "The dirigible is a magnificent vessel. How dare he!";
        eventQueue[10][17] = "Just appease him and we’ll be fine. And don’t make any sudden moves.";
        eventQueue[10][18] = "If it flies, it’s fine by me. Anything that can achieve flight must be well-designed as man was never born to fly.";
        eventQueue[10][19] = "This method of sky travel, while able to cover long distances, is incredibly susceptible to explosions. These vessels are practically time bombs; it’s not if it will explode, it’s when. But on the other hand, they can carry so much cargo compared to the constrained width of trains…";
        eventQueue[10][20] = "I wasn’t really listening and then it got quiet. Don’t look at me.";
        eventQueue[10][21] = "If dirigibles were such a good design, then why are they so easy to blow up? I think I’ll take a pamphlet from this man.";
        eventQueue[10][22] = "It’s a scientific wonder! This fellow is completely mad to deny the technological titan that is the dirigible! Humans able to take flight! What would take a buggy 50 days to travel would only take 15 hours on a blimp! Sure, the explosions can be a major setback, but they are statistically highly unlikely!";
        eventQueue[10][23] = "I don’t get it… let’s move on.";
        eventQueue[10][24] = "What a sad, strange little man.";
        eventQueue[10][25] = "Nevermind, I guess.";
        eventQueue[10][26] = "Pompous fool.";
        eventQueue[10][27] = "We should’ve blasted his ship. That’d shut him up.";
        eventQueue[10][28] = "...";
        eventQueue[10][29] = "What just happened?";
        eventQueue[10][30] = "I guess, we’ll be on our way, then.";
        eventQueue[10][31] = "Okay, back on track.";
        eventQueue[10][32] = "What the… we needed that!";
        eventQueue[10][33] = "Well, that was weird.";
        eventQueue[10][34] = "This is probably for the better.";
        eventQueue[10][35] = "Let’s hope we didn’t need that one…";
        eventQueue[10][36] = "...but I wanted to here more.";
        eventQueue[10][37] = "Guess we’ll never know...";
        eventQueue[10][38] = "Get back here! I’m not finished with that pagan filth!";
        eventQueue[10][39] = "I hope to never see that man again.";
        eventQueue[10][40] = "So be it.";
        //==============================================================
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
